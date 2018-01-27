using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormFileName : Form
    {
        public FormFileName(List<string> alst , List<string> blst)
        {
            InitializeComponent();

            if (alst.Count != blst.Count) return;

            for (int i = 0; i < alst.Count; i++)
            {

                this.dataGridView1.Rows.Add(alst[i],blst[i]);

                if (alst[i] != blst[i])
                {
                    this.dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Gray;
                }
            }

        }

    }
}
