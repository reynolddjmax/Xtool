using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormSearch : Form
    {
        public FormSearch()
        {
            InitializeComponent();
        }

        #region Definitions  
        //Constants for API Calls...  
        private const int WM_DRAWCLIPBOARD = 0x308;
        private const int WM_CHANGECBCHAIN = 0x30D;

        //Handle for next clipboard viewer...  
        private IntPtr mNextClipBoardViewerHWnd;

        //API declarations...  
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static public extern IntPtr SetClipboardViewer(IntPtr hWndNewViewer);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static public extern bool ChangeClipboardChain(IntPtr HWnd, IntPtr HWndNext);
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);
        #endregion


        private void FormSearch_Load(object sender, EventArgs e)
        {
            mNextClipBoardViewerHWnd = SetClipboardViewer(this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    {
                        //The clipboard has changed...  
                        //##########################################################################  
                        // Process Clipboard Here :)........................  
                        //##########################################################################  
                        SendMessage(mNextClipBoardViewerHWnd, m.Msg, m.WParam.ToInt32(), m.LParam.ToInt32());

                        //显示剪贴板中的文本信息  
                        if (Clipboard.ContainsText())
                        {
                            //MessageBox.Show(Clipboard.GetText());

                            Doo(Clipboard.GetText());


                        }
                        //显示剪贴板中的图片信息  
                        if (Clipboard.ContainsImage())
                        {
                            //pictureBox1.Image = Clipboard.GetImage();
                            //pictureBox1.Update();
                        }
                        break;
                    }
                case WM_CHANGECBCHAIN:
                    {
                        //Another clipboard viewer has removed itself...  
                        if (m.WParam == (IntPtr)mNextClipBoardViewerHWnd)
                        {
                            mNextClipBoardViewerHWnd = m.LParam;
                        }
                        else
                        {
                            SendMessage(mNextClipBoardViewerHWnd, m.Msg, m.WParam.ToInt32(), m.LParam.ToInt32());
                        }
                        break;
                    }
            }
            base.WndProc(ref m);
        }


        bool isFirstTime = true;


        //搜索剪切板内容
        void Doo(string Str)
        {
            if (isFirstTime)
            {
                isFirstTime = false;
                return;
            }


            if (radioButton1.Checked)
            {
                Str = getSerialName(Str);
            }
            else if (radioButton2.Checked)
            {

            }
            else if (radioButton3.Checked)
            {

            }
            else if (radioButton4.Checked)
            {
                return;
            }






            if (Str == "")
            {
                return;
            }


            DLL.SystemCMD.RunCmd("cmd.exe","c:\\Soft\\everything\\Everything.exe -s \"" + Str + "\"");
        }

        //拖入文件搜索
        private void Form_DragEnter(object sender, DragEventArgs e)
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

        private void Form_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            foreach (string o in s)
            {
                //搜索拖入的路径，是目录，扫描视频文件
                string Str = "";
                if (CodeAll.isVideo(o))
                {
                    if (radioButton1.Checked)
                    {
                        Str = getSerialName(o);
                    }
                    
                }

                if (Str != "") DLL.SystemCMD.RunCmd("cmd.exe", "c:\\Soft\\everything\\Everything.exe -s \"" + Str + "\"");


            }

        }




        //传入 XXX111 或XXX-111 返回 XXX 111
        public static string getSerialName(string str)
        {
            str = str.Replace("-","");

            if (str.Length < 5)
            {
                return "";
            }

            string listtemp = "";
            for (int i = 0; i < str.Length; i++)
            {

                char s = str[i];

                if (isNumOrEn(s))
                {
                    listtemp += s;
                }
                else if (isserial(listtemp))
                {

                    //添加空格
                    for (int j = 0; j < listtemp.Length; j++)
                    {
                        if (isNum(listtemp[j]))
                        {
                            listtemp = listtemp.Insert(j, " ");
                            break;
                        }
                            
                    }

                        return listtemp;
                }
                else
                {
                    listtemp = "";
                }


            }


            //增加一个判断 全字都是匹配的情况
            if (isserial(listtemp))
            {

                //添加空格
                for (int j = 0; j < listtemp.Length; j++)
                {
                    if (isNum(listtemp[j]))
                    {
                        listtemp = listtemp.Insert(j, " ");
                        break;
                    }

                }

                return listtemp;
            }



            return "";
        }
        public static bool isNumOrEn(char str)
        {
            int n = (int)str;
            if ((n >= 48 && n <= 57) || (n >= 65 && n <= 90) || (n >= 97 && n <= 122))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool isNum(char str)
        {
            int n = (int)str;
            if (n >= 48 && n <= 57)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool isEn(char str)
        {
            int n = (int)str;
            if ((n >= 65 && n <= 90) || (n >= 97 && n <= 122))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool isserial(string str)
        {

            //判断是否太短

            if (str.Length < 5)
            {
                return false;
            }

            //判断前两个字符是否英文
            if (!isEn(str[0]) || !isEn(str[1]))
            {
                return false;
            }
            //判断最后一个字符是否数字
            if (!isNum(str[str.Length - 1]) || !isNum(str[str.Length - 2]))
            {
                return false;
            }


            //判断是否日期
            if (str.IndexOf("2013") != -1 || str.IndexOf("2014") != -1 || str.IndexOf("2015") != -1 || str.IndexOf("2016") != -1 || str.IndexOf("2017") != -1)
            {
                return false;
            }


            //判断英文字符是否连续


            bool enEnd = false;
            for (int i = 0; i < str.Length; i++)
            {

                if (isEn(str[i]) && !enEnd)
                {
                    continue;
                }
                else
                {
                    enEnd = true;

                    if (!isNum(str[i]))
                    {
                        return false;
                    }
                }




            }

            return true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
    }
}
