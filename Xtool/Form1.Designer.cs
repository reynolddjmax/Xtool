namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxFile = new System.Windows.Forms.ListBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.radioButtonG = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.radioButtonJ = new System.Windows.Forms.RadioButton();
            this.radioButtonTV = new System.Windows.Forms.RadioButton();
            this.radioButtonTXT = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IsDel = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MD5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button8 = new System.Windows.Forms.Button();
            this.listBoxNameSet = new System.Windows.Forms.ListBox();
            this.button10 = new System.Windows.Forms.Button();
            this.listBoxMD5 = new System.Windows.Forms.ListBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelSame = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button22 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button20 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.tabPageWeb = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button17 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(779, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 24);
            this.button1.TabIndex = 0;
            this.button1.Text = "文件夹整理";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxFile
            // 
            this.listBoxFile.AllowDrop = true;
            this.listBoxFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxFile.FormattingEnabled = true;
            this.listBoxFile.HorizontalScrollbar = true;
            this.listBoxFile.ItemHeight = 12;
            this.listBoxFile.Location = new System.Drawing.Point(3, 20);
            this.listBoxFile.Name = "listBoxFile";
            this.listBoxFile.Size = new System.Drawing.Size(698, 136);
            this.listBoxFile.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(86, 189);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "删除文件";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(890, 551);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Clean";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Font = new System.Drawing.Font("宋体", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Red;
            this.richTextBox1.Location = new System.Drawing.Point(14, 580);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(951, 99);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // radioButtonG
            // 
            this.radioButtonG.AutoSize = true;
            this.radioButtonG.Location = new System.Drawing.Point(14, 167);
            this.radioButtonG.Name = "radioButtonG";
            this.radioButtonG.Size = new System.Drawing.Size(101, 16);
            this.radioButtonG.TabIndex = 10;
            this.radioButtonG.TabStop = true;
            this.radioButtonG.Text = "G(不创建文本)";
            this.radioButtonG.UseVisualStyleBackColor = true;
            // 
            // radioButtonF
            // 
            this.radioButtonF.AutoSize = true;
            this.radioButtonF.Location = new System.Drawing.Point(121, 167);
            this.radioButtonF.Name = "radioButtonF";
            this.radioButtonF.Size = new System.Drawing.Size(29, 16);
            this.radioButtonF.TabIndex = 11;
            this.radioButtonF.TabStop = true;
            this.radioButtonF.Text = "F";
            this.radioButtonF.UseVisualStyleBackColor = true;
            // 
            // radioButtonJ
            // 
            this.radioButtonJ.AutoSize = true;
            this.radioButtonJ.Location = new System.Drawing.Point(173, 167);
            this.radioButtonJ.Name = "radioButtonJ";
            this.radioButtonJ.Size = new System.Drawing.Size(29, 16);
            this.radioButtonJ.TabIndex = 12;
            this.radioButtonJ.TabStop = true;
            this.radioButtonJ.Text = "J";
            this.radioButtonJ.UseVisualStyleBackColor = true;
            // 
            // radioButtonTV
            // 
            this.radioButtonTV.AutoSize = true;
            this.radioButtonTV.Location = new System.Drawing.Point(225, 167);
            this.radioButtonTV.Name = "radioButtonTV";
            this.radioButtonTV.Size = new System.Drawing.Size(35, 16);
            this.radioButtonTV.TabIndex = 13;
            this.radioButtonTV.TabStop = true;
            this.radioButtonTV.Text = "TV";
            this.radioButtonTV.UseVisualStyleBackColor = true;
            // 
            // radioButtonTXT
            // 
            this.radioButtonTXT.AutoSize = true;
            this.radioButtonTXT.Location = new System.Drawing.Point(277, 167);
            this.radioButtonTXT.Name = "radioButtonTXT";
            this.radioButtonTXT.Size = new System.Drawing.Size(65, 16);
            this.radioButtonTXT.TabIndex = 15;
            this.radioButtonTXT.TabStop = true;
            this.radioButtonTXT.Text = "OnlyTXT";
            this.radioButtonTXT.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(199, 189);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "添加数据库";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsDel,
            this.Name1,
            this.Name2,
            this.Type1,
            this.Type2,
            this.Size1,
            this.Size2,
            this.MD5,
            this.FilePath});
            this.dataGridView1.Location = new System.Drawing.Point(0, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(941, 250);
            this.dataGridView1.TabIndex = 18;
            // 
            // IsDel
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.NullValue = false;
            this.IsDel.DefaultCellStyle = dataGridViewCellStyle13;
            this.IsDel.HeaderText = "IsDel";
            this.IsDel.Name = "IsDel";
            this.IsDel.Width = 40;
            // 
            // Name1
            // 
            this.Name1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name1.DefaultCellStyle = dataGridViewCellStyle14;
            this.Name1.FillWeight = 1000F;
            this.Name1.HeaderText = "Name1(Data)";
            this.Name1.Name = "Name1";
            this.Name1.Width = 96;
            // 
            // Name2
            // 
            this.Name2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Red;
            this.Name2.DefaultCellStyle = dataGridViewCellStyle15;
            this.Name2.FillWeight = 1000F;
            this.Name2.HeaderText = "Name2(New)";
            this.Name2.Name = "Name2";
            this.Name2.Width = 90;
            // 
            // Type1
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Type1.DefaultCellStyle = dataGridViewCellStyle16;
            this.Type1.HeaderText = "Type1(Data)";
            this.Type1.Name = "Type1";
            // 
            // Type2
            // 
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Red;
            this.Type2.DefaultCellStyle = dataGridViewCellStyle17;
            this.Type2.HeaderText = "Type2(New)";
            this.Type2.Name = "Type2";
            // 
            // Size1
            // 
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Size1.DefaultCellStyle = dataGridViewCellStyle18;
            this.Size1.HeaderText = "Size1(Data)";
            this.Size1.Name = "Size1";
            // 
            // Size2
            // 
            this.Size2.HeaderText = "Size2(New)";
            this.Size2.Name = "Size2";
            // 
            // MD5
            // 
            this.MD5.HeaderText = "MD5";
            this.MD5.Name = "MD5";
            // 
            // FilePath
            // 
            this.FilePath.HeaderText = "FilePath";
            this.FilePath.Name = "FilePath";
            this.FilePath.Width = 550;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(787, 402);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 23);
            this.button8.TabIndex = 19;
            this.button8.Text = "添加文件名";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // listBoxNameSet
            // 
            this.listBoxNameSet.AllowDrop = true;
            this.listBoxNameSet.FormattingEnabled = true;
            this.listBoxNameSet.ItemHeight = 12;
            this.listBoxNameSet.Location = new System.Drawing.Point(9, 11);
            this.listBoxNameSet.Name = "listBoxNameSet";
            this.listBoxNameSet.Size = new System.Drawing.Size(760, 220);
            this.listBoxNameSet.TabIndex = 21;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(5, 189);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 24;
            this.button10.Text = "检查";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // listBoxMD5
            // 
            this.listBoxMD5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxMD5.FormattingEnabled = true;
            this.listBoxMD5.ItemHeight = 12;
            this.listBoxMD5.Location = new System.Drawing.Point(705, 20);
            this.listBoxMD5.Name = "listBoxMD5";
            this.listBoxMD5.Size = new System.Drawing.Size(240, 136);
            this.listBoxMD5.TabIndex = 25;
            this.listBoxMD5.SelectedIndexChanged += new System.EventHandler(this.listBoxMD5_SelectChange);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button11.Location = new System.Drawing.Point(6, 483);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 26;
            this.button11.Text = "删除文件";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button12.Location = new System.Drawing.Point(740, 483);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(151, 23);
            this.button12.TabIndex = 27;
            this.button12.Text = "重命名选中行，更新del";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(676, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 28;
            this.label2.Text = "...";
            // 
            // buttonDelSame
            // 
            this.buttonDelSame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelSame.Location = new System.Drawing.Point(844, 160);
            this.buttonDelSame.Name = "buttonDelSame";
            this.buttonDelSame.Size = new System.Drawing.Size(95, 23);
            this.buttonDelSame.TabIndex = 29;
            this.buttonDelSame.Text = "删除重复文件";
            this.buttonDelSame.UseVisualStyleBackColor = true;
            this.buttonDelSame.Click += new System.EventHandler(this.buttonDelSame_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPageWeb);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.ItemSize = new System.Drawing.Size(120, 30);
            this.tabControl1.Location = new System.Drawing.Point(14, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 537);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button19);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonDelSame);
            this.tabPage1.Controls.Add(this.button18);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.listBoxMD5);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button12);
            this.tabPage1.Controls.Add(this.listBoxFile);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.radioButtonJ);
            this.tabPage1.Controls.Add(this.radioButtonG);
            this.tabPage1.Controls.Add(this.radioButtonF);
            this.tabPage1.Controls.Add(this.radioButtonTV);
            this.tabPage1.Controls.Add(this.radioButtonTXT);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage1.Size = new System.Drawing.Size(941, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "    DataBase    ";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button19.Location = new System.Drawing.Point(660, 483);
            this.button19.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(75, 23);
            this.button19.TabIndex = 29;
            this.button19.Text = "筛选重复";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button18
            // 
            this.button18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button18.Location = new System.Drawing.Point(896, 483);
            this.button18.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(44, 23);
            this.button18.TabIndex = 28;
            this.button18.Text = "全否";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button22);
            this.tabPage4.Controls.Add(this.listBoxNameSet);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.button8);
            this.tabPage4.Controls.Add(this.button21);
            this.tabPage4.Controls.Add(this.checkBox1);
            this.tabPage4.Controls.Add(this.button20);
            this.tabPage4.Controls.Add(this.button16);
            this.tabPage4.Controls.Add(this.textBox3);
            this.tabPage4.Controls.Add(this.textBox2);
            this.tabPage4.Controls.Add(this.button15);
            this.tabPage4.Controls.Add(this.button14);
            this.tabPage4.Controls.Add(this.button13);
            this.tabPage4.Controls.Add(this.richTextBox2);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage4.Size = new System.Drawing.Size(941, 499);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "   NameTool   ";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button22.Location = new System.Drawing.Point(779, 40);
            this.button22.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(75, 24);
            this.button22.TabIndex = 22;
            this.button22.Text = "合并视频";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.button22_Click);
            // 
            // button21
            // 
            this.button21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button21.Location = new System.Drawing.Point(219, 461);
            this.button21.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(73, 26);
            this.button21.TabIndex = 34;
            this.button21.Text = "对比";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.button21_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 490);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 33;
            this.checkBox1.Text = "所有文件";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button20.Location = new System.Drawing.Point(85, 461);
            this.button20.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(73, 26);
            this.button20.TabIndex = 32;
            this.button20.Text = "大写";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button16
            // 
            this.button16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button16.Location = new System.Drawing.Point(787, 253);
            this.button16.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(124, 26);
            this.button16.TabIndex = 6;
            this.button16.Text = "S站名称去英文";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(786, 369);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(141, 21);
            this.textBox3.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(786, 293);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 21);
            this.textBox2.TabIndex = 4;
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.Location = new System.Drawing.Point(786, 327);
            this.button15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(78, 26);
            this.button15.TabIndex = 3;
            this.button15.Text = "替换";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button14.Location = new System.Drawing.Point(295, 461);
            this.button14.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(73, 26);
            this.button14.TabIndex = 2;
            this.button14.Text = "修改";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button13
            // 
            this.button13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button13.Location = new System.Drawing.Point(9, 461);
            this.button13.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(73, 26);
            this.button13.TabIndex = 1;
            this.button13.Text = "获取";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBox2.Location = new System.Drawing.Point(9, 235);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(760, 217);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // tabPageWeb
            // 
            this.tabPageWeb.Location = new System.Drawing.Point(4, 34);
            this.tabPageWeb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageWeb.Name = "tabPageWeb";
            this.tabPageWeb.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageWeb.Size = new System.Drawing.Size(941, 499);
            this.tabPageWeb.TabIndex = 4;
            this.tabPageWeb.Text = "    Web    ";
            this.tabPageWeb.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button17);
            this.tabPage3.Controls.Add(this.button24);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPage3.Size = new System.Drawing.Size(941, 499);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "    Other    ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(20, 17);
            this.button17.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(78, 29);
            this.button17.TabIndex = 7;
            this.button17.Text = "开始监视";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(20, 153);
            this.button24.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(78, 31);
            this.button24.TabIndex = 35;
            this.button24.Text = "Test";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 691);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxFile;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton radioButtonG;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.RadioButton radioButtonJ;
        private System.Windows.Forms.RadioButton radioButtonTV;
        private System.Windows.Forms.RadioButton radioButtonTXT;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.ListBox listBoxNameSet;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ListBox listBoxMD5;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelSame;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.TabPage tabPageWeb;
    }
}

