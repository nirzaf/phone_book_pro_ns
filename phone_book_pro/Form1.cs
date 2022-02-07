using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phone_book_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Reg_data rg = new Reg_data();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Search_Form rg = new Search_Form();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            About_us rg = new About_us();
            rg.MdiParent = this;
            rg.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.process1.StartInfo.FileName = "C:\\Windows\\System32\\calc.exe";
            this.process1.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.F2 )
            {
                toolStripButton1_Click(sender, e);
            }
            //---------------------------
            if (e.KeyCode == Keys.F3)
            {
                toolStripButton2_Click(sender, e);
            }
            //---------------------------
            if (e.KeyCode == Keys.F4)
            {
                toolStripButton3_Click(sender, e);
            }
            //---------------------------
            if (e.KeyCode == Keys.F5)
            {
                toolStripButton4_Click(sender, e);
            }
            //---------------------------
            if (e.KeyCode == Keys.Escape )
            {
                toolStripButton5_Click(sender, e);
            }
            //---------------------------
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
