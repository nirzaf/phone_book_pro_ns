using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phone_book_pro
{
    public partial class Search_Form : Form
    {
        public Search_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }
            //-----------------------------
            string fn;
            fn = "E:\\tuts\\";
            string p;
            string r;
            //------------ first name -------------------------
            p = fn + this.textBox1.Text + "_fn.txt";
            if (System.IO.File.Exists(p)==true )
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.fn_textBox2.Text = r;
            }
            //---------------------------------------------------
            //------------ last name -------------------------
            p = fn + this.textBox1.Text + "_ln.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.ln_textBox3.Text = r;
            }
            //------------ tel -------------------------
            p = fn + this.textBox1.Text + "_tel.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.tel_textBox4.Text = r;
            }
            //------------ cell -------------------------
            p = fn + this.textBox1.Text + "_cell.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.cell_textBox5.Text = r;
            }
            //------------ email -------------------------
            p = fn + this.textBox1.Text + "_email.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.email_textBox6 .Text = r;
            }
            //------------ address -------------------------
            p = fn + this.textBox1.Text + "_add.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.add_textBox7 .Text = r;
            }
            //------------ comment -------------------------
            p = fn + this.textBox1.Text + "_comm.txt";
            if (System.IO.File.Exists(p) == true)
            {
                r = System.IO.File.ReadAllText(p, Encoding.UTF8);
                this.comm_textBox8.Text = r;
            }
            //----------------------------------------------------
            this.id_textBox1.Text = this.textBox1.Text;

        }
    }
}
