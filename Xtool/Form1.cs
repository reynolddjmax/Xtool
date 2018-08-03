using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //this.DragEnter += new DragEventHandler(Form1_DragEnter);
            //this.DragDrop += new DragEventHandler(Form1_DragDrop);

            this.listBoxFile.DragEnter += new DragEventHandler(listBoxFile_DragEnter);
            this.listBoxFile.DragDrop += new DragEventHandler(listBoxFile_DragDrop);
            this.listBoxFile.DoubleClick += new System.EventHandler(listBoxFile_DoubleClick);

            this.listBoxNameSet.DragEnter += new DragEventHandler(listBoxNameSet_DragEnter);
            this.listBoxNameSet.DragDrop += new DragEventHandler(listBoxNameSet_DragDrop);
            this.listBoxNameSet.DoubleClick += new System.EventHandler(this.listBoxNameSet_DoubleClick);


            setting.LogBox = this.richTextBox1;

            Web.Web web1 = new Web.Web();
            web1.Dock = DockStyle.Fill;
            this.tabPageWeb.Controls.Add(web1);
        }


        public string GetDataType()
        {

            if (this.radioButtonF.Checked)
            {
                return "F";
            }
            else if (this.radioButtonG.Checked)
            {
                return "G";
            }
            else if (this.radioButtonJ.Checked)
            {
                return "J";
            }
            else if (this.radioButtonTV.Checked)
            {
                return "TV";
            }
            else if (this.radioButtonTXT.Checked)
            {
                return "TXT";
            }
            else
            {
                return "";
            }

        }

        public void Clear()
        {
            this.listBoxFile.Items.Clear();
            this.listBoxNameSet.Items.Clear();
            this.listBoxMD5.Items.Clear();


            this.radioButtonF.Checked = false;
            this.radioButtonJ.Checked = false;
            this.radioButtonTV.Checked = false;
            this.radioButtonG.Checked = false;
            this.radioButtonTXT.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //只判断处理文件夹
            foreach (string path in this.listBoxNameSet.Items)
            {
                if (Directory.Exists(path))
                {
                    string NewName = path.Substring(path.LastIndexOf("\\") + 1);
                    string NewPath = path.Remove(path.LastIndexOf("\\"));

                    List<string> file = CodeAll.ScanVideo(path, "*", SearchOption.AllDirectories);
                    if (file.Count != 1)
                    {
                        continue;
                    }

                    if (File.Exists(NewPath +"\\" + NewName + Path.GetExtension(file[0])))
                    {

                        continue;
                    }

                    try
                    {
                        File.Move(file[0], NewPath + "\\" + NewName + Path.GetExtension(file[0]));
                        Directory.Delete(path, true);
                    }
                    catch (Exception ex)
                    {

                        CodeAll.AddLog("移动失败", path, ex.Message);
                    }
                    
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            access.Open();
            if (MessageBox.Show("是否确认删除", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK) return;

            


            for (int i = 0; i < this.listBoxFile.Items.Count; i++)
            {
                string path = this.listBoxFile.Items[i].ToString();
                string Name = Path.GetFileNameWithoutExtension(path);


                if (GetDataType() == "")
                {
                    MessageBox.Show("未选择类型");

                    return;
                }

                string DataType = GetDataType();

                //除了G创建文本数据库
                if (DataType != "G")
                {
                    CodeClass.CreatTxtFile(path, Name);
                }


                //除了TXT模式创建MDB数据库
                if (DataType != "TXT")
                {
                    //listboxMD5数据数量不一致就重新计算MD5

                    string MD5 = "";


                    if (this.listBoxMD5.Items.Count == this.listBoxFile.Items.Count)
                    {
                        MD5 = this.listBoxMD5.Items[i].ToString();
                    }

                    if (access.AddData(path, Name, DataType, "", true) == false)
                    {
                        continue;
                    }
                }


                //删除文件
                try
                {
                    File.Delete(path);
                }
                catch (Exception ex)
                {
                    CodeAll.AddLog("文件删除失败", path, ex.Message);
                    continue;
                }



            }


            Clear();

            access.Close();
        }



        private void listBoxFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBoxFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string  o in s)
            {
                //搜索拖入的路径，是目录，扫描视频文件

                if (System.IO.File.Exists(o))
                {
                    if (CodeAll.isVideo(o))
                    {
                        this.listBoxFile.Items.Add(o);
                    }
                    
                }
                else if (System.IO.Directory.Exists(o))
                {
                    List<string> lst = CodeAll.ScanVideo(o, "*", SearchOption.AllDirectories);

                    foreach (var item in lst)
                    {
                        this.listBoxFile.Items.Add(item);
                    }

                }


                
            }

        }

        private void listBoxNameSet_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }


        private void listBoxNameSet_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string o in s)
            {
                //如果是文件，只导入视频，如果是文件夹，直接导入

                if (System.IO.File.Exists(o))
                {
                    if (CodeAll.isVideo(o))
                    {
                        this.listBoxNameSet.Items.Add(o);
                    }

                }
                else if (System.IO.Directory.Exists(o))
                {

                    this.listBoxNameSet.Items.Add(o);

                }



            }

        }


        private void listBoxFile_DoubleClick(object sender, EventArgs e)
        {
            this.listBoxFile.Items.Clear();
            this.listBoxMD5.Items.Clear();
        }

        private void listBoxNameSet_DoubleClick(object sender, EventArgs e)
        {
            this.listBoxNameSet.Items.Clear();
        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Text = "";
            this.dataGridView1.Rows.Clear();

        }


        private void button5_Click(object sender, EventArgs e)
        {
            access.Open();

            int n = 0;

            for (int i = 0; i < this.listBoxFile.Items.Count; i++)
            {
                string path = this.listBoxFile.Items[i].ToString();
                string Name = Path.GetFileNameWithoutExtension(path);


                if (GetDataType() == "" || GetDataType() == "TXT")
                {
                    MessageBox.Show("未选择类型");

                    return;
                }

                string DataType = GetDataType();


                //创建MDB数据库

                //listboxMD5数据数量不一致就重新计算MD5
                string MD5 = "";
                if (this.listBoxMD5.Items.Count == this.listBoxFile.Items.Count)
                {
                    MD5 = this.listBoxMD5.Items[i].ToString();
                }

                access.AddData(path, Name, DataType, MD5, false);

                n++;
                this.label2.Text = n.ToString() + "/" + this.listBoxFile.Items.Count.ToString();
                Application.DoEvents();
            }


            Clear();

            access.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            List<string> Namelst = System.Text.RegularExpressions.Regex.Split(this.richTextBox2.Text.Trim(), "\n").ToList<string>();

            this.richTextBox2.Text = "";

            foreach (string item in Namelst)
            {
                string NewName = this.textBox3.Text + " " + item;

                

                this.richTextBox2.Text += NewName + "\n";
            }

            this.richTextBox2.Text = this.richTextBox2.Text.Trim();



        }




        //检查文件是否存在数据库
        private void button10_Click(object sender, EventArgs e)
        {
            access.Open();
            int n = 0;
            this.listBoxMD5.Items.Clear();



            for (int i = 0; i < this.listBoxFile.Items.Count; i++)
            {
                string path = this.listBoxFile.Items[i].ToString();

                //校验MD5数值
                string MD5 = CodeAll.GetMD5(path);

                //检查数据库是否存在
                string DataType = "G";
                access.AccessType AT = access.CheckData(path, DataType, MD5);



                if (AT == null) 
                {
                    DataType = "F";
                    AT = access.CheckData(path, DataType, MD5);
                }

                if (AT == null)
                {
                    DataType = "J";
                    AT = access.CheckData(path, DataType, MD5);
                }

                if (AT == null)
                {
                    DataType = "TV";
                    AT = access.CheckData(path, DataType, MD5);
                }

                
                
                if (AT == null)//不存在，添加listboxMD5值
                {
                    this.listBoxMD5.Items.Add(MD5);
                    n++;
                }
                else//存在，从listboxfile中移除，并添加Datatable
                {
                    this.listBoxFile.Items.RemoveAt(i);
                    i--;

                    FileInfo fi = new FileInfo(path);
                    string Size = fi.Length.ToString();

                    string NewName = "";
                    if (AT.Name != System.IO.Path.GetFileNameWithoutExtension(path))
                    {
                        NewName = System.IO.Path.GetFileNameWithoutExtension(path);
                    }

                    this.dataGridView1.Rows.Add(
                        AT.isDel,
                        AT.Name,
                        NewName, 
                        DataType, 
                        GetDataType(),
                        AT.Size,
                        Size,
                        MD5,
                        path
                        );

                    
                }


                
                this.label2.Text = n.ToString() + "/" + this.listBoxFile.Items.Count.ToString();
                Application.DoEvents();
            }

            //检查MD5数量和文件数量
            if (this.listBoxMD5.Items.Count != this.listBoxFile.Items.Count)
            {
                MessageBox.Show("MD5数据数量和文件不一致");
            }

            //检查MD5是否有重复
            List<string> lst = new List<string>();
            CheckSameMD5List();

            access.Close();
        }


        //检查MD5列表是否有重复数据
        void CheckSameMD5List()
        {
            //删除重复项字段
            for (int i = 0; i < this.listBoxMD5.Items.Count; i++)
            {
                if (CodeClass.SameStrExist(this.listBoxMD5.Items[i].ToString()))
                {
                    this.listBoxMD5.Items[i] = CodeClass.SameStrClear(this.listBoxMD5.Items[i].ToString());
                    this.listBoxFile.Items[i] = CodeClass.SameStrClear(this.listBoxFile.Items[i].ToString());
                }
            }
            this.label2.Text = "";
            this.buttonDelSame.Visible = false;

            List<string> SameMD5 = new List<string>();
            HashSet<string> Hashlst = new HashSet<string>();

            foreach (string item in this.listBoxMD5.Items)
            {
                if (!Hashlst.Add(item))
                {
                    SameMD5.Add(item);
                    this.label2.Text = "有重复";
                    this.buttonDelSame.Visible = true;
                }
            }



            for (int i = 0; i < this.listBoxMD5.Items.Count; i++)
            {
                string MD5 = this.listBoxMD5.Items[i].ToString();

                if (SameMD5.Contains(MD5))
                {

                    this.listBoxFile.Items[i] = CodeClass.SameStrAdd(this.listBoxFile.Items[i].ToString());
                    this.listBoxMD5.Items[i] = CodeClass.SameStrAdd(this.listBoxMD5.Items[i].ToString());
                }

            }



        }




        private void button11_Click(object sender, EventArgs e)
        {

            if (this.dataGridView1.SelectedRows.Count == -1) return;

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {

                string path = item.Cells["FilePath"].Value.ToString();

                //删除文件
                try
                {
                    File.Delete(path);
                }
                catch (Exception ex)
                {
                    CodeAll.AddLog("文件删除失败", path, ex.Message);
                    continue;
                }

                this.dataGridView1.Rows.Remove(item);

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            access.Open();

            if (this.dataGridView1.SelectedRows.Count == -1) return;
            
            //更新数据库名称
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {

                string newName = item.Cells["Name2"].Value.ToString();
                string MD5 = item.Cells["MD5"].Value.ToString();
                string DataType = item.Cells["Type1"].Value.ToString();
                bool IsDel = Convert.ToBoolean(item.Cells["IsDel"].Value);


                //更新Del状态
                access.UpdateAccess("update " + DataType + " set [IsDel] = " + IsDel + " where [MD5] = '" + MD5 + "'");

                //如果Name2为空，则跳过
                if (newName.Replace(" ", "") == "") continue;

                //更新数据库文件名
                access.UpdateAccess("update " + DataType + " set [Name] = '" + newName + "' where [MD5] = '" + MD5 + "'");
            }

            //更新Datatable文件名称(所有行)  Name  IsDel

            foreach (DataGridViewRow item  in this.dataGridView1.Rows)
            {
                string MD5 = item.Cells["MD5"].Value.ToString();
                string DataType = item.Cells["Type1"].Value.ToString();

                access.AccessType AT = access.CheckData("", DataType, MD5);


                string Name = AT.Name;
                item.Cells["Name1"].Value = Name;


                string newName = item.Cells["Name2"].Value.ToString();

                if (Name == newName)
                {
                    item.Cells["Name2"].Value = "";
                }

                item.Cells["IsDel"].Value = AT.isDel;

            }

            access.Close();
        }


        private void button18_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.Rows)
            {
                item.Cells["IsDel"].Value = false;
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDelSame_Click(object sender, EventArgs e)
        {
            //删除文件
            if (this.listBoxMD5.SelectedIndex == -1 || this.listBoxFile.SelectedIndex == -1) return;

            

            string path = this.listBoxFile.Items[this.listBoxFile.SelectedIndex].ToString();
            path = CodeClass.SameStrClear(path);


            if (System.IO.File.Exists(path) == false)
            {
                CodeAll.AddLog("文件删除失败", path, "文件不存在");
                return;
            }

            //删除文件
            try
            {
                File.Delete(path);
            }
            catch (Exception ex)
            {
                CodeAll.AddLog("文件删除失败", path, ex.Message);
                return;
            }

            int selectIndex = this.listBoxFile.SelectedIndex;

            this.listBoxMD5.Items.RemoveAt(selectIndex);
            this.listBoxFile.Items.RemoveAt(selectIndex);

            CheckSameMD5List();
        }

        private void listBoxMD5_SelectChange(object sender, EventArgs e)
        {
            if (this.listBoxMD5.SelectedIndex == -1) return;

            this.listBoxFile.SelectedIndex = this.listBoxMD5.SelectedIndex;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            //是文件除去后缀添加，是文件夹直接添加
            this.richTextBox2.Text = "";
            foreach (string item in this.listBoxNameSet.Items)
            {
                string Name = "";
                if (System.IO.File.Exists(item))
                {
                    Name = System.IO.Path.GetFileNameWithoutExtension(item);
                }
                else if (System.IO.Directory.Exists(item))
                {
                    Name = System.IO.Path.GetFileName(item);
                }
                else
                {
                    MessageBox.Show("不存在" + item);
                }

                this.richTextBox2.Text += Name + "\n";
            }

            this.richTextBox2.Text = this.richTextBox2.Text.Trim();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //是文件添加后缀修改，是文件夹直接修改

            List<string> Namelst = System.Text.RegularExpressions.Regex.Split(this.richTextBox2.Text.Trim(),"\n").ToList<string>();
            if (Namelst.Count != listBoxNameSet.Items.Count)
            {
                MessageBox.Show("文件数不一致");
                return;
            }

            for (int i = 0; i < listBoxNameSet.Items.Count; i++)
            {
                string OriPath = listBoxNameSet.Items[i].ToString();

                if (File.Exists(OriPath))
                {
                    string newPath = Path.GetDirectoryName(OriPath) + "\\" + Namelst[i].Trim() + Path.GetExtension(OriPath);
                    if (File.Exists(newPath)) continue;
                    File.Move(OriPath, newPath);
                }
                else if (Directory.Exists(OriPath))
                {
                    string newPath = Path.GetDirectoryName(OriPath) + "\\" + Namelst[i].Trim();
                    if (Directory.Exists(newPath)) continue;
                    Directory.Move(OriPath, newPath);
                }
                else
                {
                    CodeAll.AddLog("文件改名失败", OriPath, "文件不存在");
                }
            }

            MessageBox.Show("Done");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.richTextBox2.Text = this.richTextBox2.Text.Replace(this.textBox2.Text, this.textBox3.Text);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            List<string> Namelst = System.Text.RegularExpressions.Regex.Split(this.richTextBox2.Text.Trim(), "\n").ToList<string>();

            this.richTextBox2.Text = "";

            foreach (string item in Namelst)
            {
                string NewName = item.Substring(item.IndexOf("(") + 1);

                NewName = NewName.Replace("  ", " ");
                NewName = NewName.Replace("  ", " ");

                NewName = NewName.Replace(") - ", " ");
                NewName = NewName.Replace(") ", " ");
                this.richTextBox2.Text += NewName + "\n";
            }

            this.richTextBox2.Text = this.richTextBox2.Text.Trim();
        }


        private void button17_Click(object sender, EventArgs e)
        {
            FormSearch fs = new FormSearch();
            fs.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {

            List<string> Namelst = System.Text.RegularExpressions.Regex.Split(this.richTextBox2.Text.Trim(), "\n").ToList<string>();

            this.richTextBox2.Text = "";

            foreach (string item in Namelst)
            {
                string NewName = item;

                NewName = NewName.Replace("  "," ");
                NewName = NewName.Replace("  "," ");

                NewName = NewName.Trim();

                List<string> serolst = NewName.Split(' ').ToList<string>();



                if (serolst.Count >= 3)
                {


                    for (int i = 0; i < 3; i++)
                    {
                        if (serolst[i].IndexOf("-") != -1)
                        {
                            serolst[i] = serolst[i].ToUpper();
                            break;
                        }
                    }


                    NewName = String.Join(" ", serolst);
                }




                this.richTextBox2.Text += NewName + "\n";
            }

            this.richTextBox2.Text = this.richTextBox2.Text.Trim();


        }

        private void button21_Click(object sender, EventArgs e)
        {
            List<string> blst = System.Text.RegularExpressions.Regex.Split(this.richTextBox2.Text.Trim(), "\n").ToList<string>();
            List<string> alst = new List<string>();
            for (int i = 0; i < listBoxNameSet.Items.Count; i++)
            {
                string OriPath = System.IO.Path.GetFileNameWithoutExtension(listBoxNameSet.Items[i].ToString());

                alst.Add(OriPath);
            }

            FormFileName fm = new FormFileName(alst, blst);
            fm.ShowDialog();
            fm.Dispose();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //只处理文件夹
            string WorkPath = setting.ConcatVideoPath;
            System.IO.Directory.CreateDirectory(WorkPath);
            string txtLst = "";
            string txtSh = "";

            int index = 0;
            foreach (string folder in listBoxNameSet.Items)
            {
                if (!Directory.Exists(folder)) continue;

                List<string> files = CodeAll.ScanVideo(folder, "*", SearchOption.TopDirectoryOnly);

                if (files.Count < 2) continue;
                files.Sort();

                string txtConcat = "";

                txtLst += folder + "\r\n";
                foreach (string file in files)
                {
                    txtLst += "\t\t" + System.IO.Path.GetFileName(file) + "\r\n";
                    txtConcat += "file '" + ConcatTransFolder(file) + "'\n";
                }

                DLL.TxtStr.Write(txtConcat, WorkPath + index.ToString()+ ".txt" , true, new System.Text.UTF8Encoding(false));

                txtSh += "ffmpeg -f concat -safe 0 -i " + index.ToString() + ".txt" +  " -c copy " + " '" + ConcatTransFolder(folder) + "/all" + System.IO.Path.GetExtension(files[0]) + "'\n";

                txtSh += "chmod 777 '" + ConcatTransFolder(folder) + "/all" + System.IO.Path.GetExtension(files[0]) + "'\n";

                index++;
            }

            DLL.TxtStr.Write(txtSh, WorkPath + "x.sh", true ,new System.Text.UTF8Encoding(false));
            DLL.TxtStr.Write(txtLst, WorkPath + "lst.txt",true);
        }

        string ConcatTransFolder(string folder)
        {

            if (folder.IndexOf(":") == 1) //如果路径为盘符
            {
                folder = folder.Replace("\\", "/");
                folder = folder.Substring(3);
                folder = setting.localPath + folder;
            }
            else //如果路劲为IP
            {
                folder = folder.Replace(setting.IP,setting.localPath);
                folder = folder.Replace("\\", "/");
            }
            

            return folder;
        }

        

        private void button24_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
