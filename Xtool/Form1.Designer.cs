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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxFile = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button7 = new System.Windows.Forms.Button();
            this.radioButtonG = new System.Windows.Forms.RadioButton();
            this.radioButtonF = new System.Windows.Forms.RadioButton();
            this.radioButtonJ = new System.Windows.Forms.RadioButton();
            this.radioButtonTV = new System.Windows.Forms.RadioButton();
            this.radioButtonTXT = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBoxfolder = new System.Windows.Forms.ListBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.listBoxMD5 = new System.Windows.Forms.ListBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDelSame = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
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
            this.listBoxFile.Location = new System.Drawing.Point(173, 108);
            this.listBoxFile.Name = "listBoxFile";
            this.listBoxFile.Size = new System.Drawing.Size(538, 124);
            this.listBoxFile.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(790, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "S站重命名";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(871, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(280, 7);
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
            this.button6.Location = new System.Drawing.Point(891, 548);
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
            this.richTextBox1.Location = new System.Drawing.Point(14, 577);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(952, 99);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(871, 34);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 9;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // radioButtonG
            // 
            this.radioButtonG.AutoSize = true;
            this.radioButtonG.Location = new System.Drawing.Point(173, 72);
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
            this.radioButtonF.Location = new System.Drawing.Point(280, 72);
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
            this.radioButtonJ.Location = new System.Drawing.Point(332, 72);
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
            this.radioButtonTV.Location = new System.Drawing.Point(384, 72);
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
            this.radioButtonTXT.Location = new System.Drawing.Point(435, 72);
            this.radioButtonTXT.Name = "radioButtonTXT";
            this.radioButtonTXT.Size = new System.Drawing.Size(65, 16);
            this.radioButtonTXT.TabIndex = 15;
            this.radioButtonTXT.TabStop = true;
            this.radioButtonTXT.Text = "OnlyTXT";
            this.radioButtonTXT.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(411, 7);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "添加数据库";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 527);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 17;
            this.label1.Text = "label1";
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(952, 302);
            this.dataGridView1.TabIndex = 18;
            // 
            // IsDel
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.NullValue = false;
            this.IsDel.DefaultCellStyle = dataGridViewCellStyle1;
            this.IsDel.HeaderText = "IsDel";
            this.IsDel.Name = "IsDel";
            this.IsDel.Width = 40;
            // 
            // Name1
            // 
            this.Name1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Name1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Name1.FillWeight = 1000F;
            this.Name1.HeaderText = "Name1(Data)";
            this.Name1.Name = "Name1";
            this.Name1.Width = 96;
            // 
            // Name2
            // 
            this.Name2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Red;
            this.Name2.DefaultCellStyle = dataGridViewCellStyle3;
            this.Name2.FillWeight = 1000F;
            this.Name2.HeaderText = "Name2(New)";
            this.Name2.Name = "Name2";
            this.Name2.Width = 90;
            // 
            // Type1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Type1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Type1.HeaderText = "Type1(Data)";
            this.Type1.Name = "Type1";
            // 
            // Type2
            // 
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            this.Type2.DefaultCellStyle = dataGridViewCellStyle5;
            this.Type2.HeaderText = "Type2(New)";
            this.Type2.Name = "Type2";
            // 
            // Size1
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Size1.DefaultCellStyle = dataGridViewCellStyle6;
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
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(591, 7);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 23);
            this.button8.TabIndex = 19;
            this.button8.Text = "添加文件名";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(549, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(291, 21);
            this.textBox1.TabIndex = 20;
            // 
            // listBoxfolder
            // 
            this.listBoxfolder.AllowDrop = true;
            this.listBoxfolder.FormattingEnabled = true;
            this.listBoxfolder.ItemHeight = 12;
            this.listBoxfolder.Location = new System.Drawing.Point(12, 36);
            this.listBoxfolder.Name = "listBoxfolder";
            this.listBoxfolder.Size = new System.Drawing.Size(155, 196);
            this.listBoxfolder.TabIndex = 21;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(679, 7);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 23;
            this.button9.Text = "清除";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(173, 7);
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
            this.listBoxMD5.Location = new System.Drawing.Point(717, 108);
            this.listBoxMD5.Name = "listBoxMD5";
            this.listBoxMD5.Size = new System.Drawing.Size(247, 124);
            this.listBoxMD5.TabIndex = 25;
            this.listBoxMD5.SelectedIndexChanged += new System.EventHandler(this.listBoxMD5_SelectChange);
            // 
            // button11
            // 
            this.button11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button11.Location = new System.Drawing.Point(14, 548);
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
            this.button12.Location = new System.Drawing.Point(95, 548);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 27;
            this.button12.Text = "重命名";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 12);
            this.label2.TabIndex = 28;
            // 
            // buttonDelSame
            // 
            this.buttonDelSame.Location = new System.Drawing.Point(851, 82);
            this.buttonDelSame.Name = "buttonDelSame";
            this.buttonDelSame.Size = new System.Drawing.Size(95, 23);
            this.buttonDelSame.TabIndex = 29;
            this.buttonDelSame.Text = "删除重复文件";
            this.buttonDelSame.UseVisualStyleBackColor = true;
            this.buttonDelSame.Visible = false;
            this.buttonDelSame.Click += new System.EventHandler(this.buttonDelSame_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(591, 63);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(144, 23);
            this.button13.TabIndex = 30;
            this.button13.Text = "flv1、fl.v、fl.pbf";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 688);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.buttonDelSame);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.listBoxMD5);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.listBoxfolder);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.radioButtonTXT);
            this.Controls.Add(this.radioButtonTV);
            this.Controls.Add(this.radioButtonJ);
            this.Controls.Add(this.radioButtonF);
            this.Controls.Add(this.radioButtonG);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listBoxFile);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxFile;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.RadioButton radioButtonG;
        private System.Windows.Forms.RadioButton radioButtonF;
        private System.Windows.Forms.RadioButton radioButtonJ;
        private System.Windows.Forms.RadioButton radioButtonTV;
        private System.Windows.Forms.RadioButton radioButtonTXT;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBoxfolder;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.ListBox listBoxMD5;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsDel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MD5;
        private System.Windows.Forms.DataGridViewTextBoxColumn FilePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDelSame;
        private System.Windows.Forms.Button button13;
        
    }
}

