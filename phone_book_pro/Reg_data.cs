using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phone_book_pro
{
    public partial class Reg_data : Form
    {
        public Reg_data()
        {
            InitializeComponent();
        }

        private void New_butt_Click(object sender, EventArgs e)
        {
            this.New_butt.Enabled = false;
            this.Save_butt.Enabled = true;
            //------------------------------
            this.Info_gbox.Enabled = true;
            //-----------Clear Textboxes---------
            this.id_textBox1.ResetText();
            this.fn_textBox2.ResetText();
            this.ln_textBox3.ResetText();
            this.tel_textBox4.ResetText();
            this.cell_textBox5.ResetText();
            this.email_textBox6.ResetText();
            this.add_textBox7.ResetText();
            this.comm_textBox8.ResetText();

            //-----------------------------------
        }

        private void Save_butt_Click(object sender, EventArgs e)
        {
            if (this.id_textBox1.Text=="")
            {
                MessageBox.Show("You must enter the ID!");
                return;
            }
            //-----------------------------
            this.Save_butt.Enabled = false;
            this.New_butt.Enabled = true;
            //---------------------------
            this.Info_gbox.Enabled = false;
            //-----------------------------
            string fn;
            fn = "E:\\tuts\\";
            string p;
            //------------ first name -------------------------
            p = fn + this.id_textBox1.Text + "_fn.txt";
            System.IO.File.WriteAllText(p, this.fn_textBox2.Text, Encoding.UTF8);
            //------------last name ---------------------------
            p = fn + this.id_textBox1.Text + "_ln.txt";
            System.IO.File.WriteAllText(p, this.ln_textBox3.Text, Encoding.UTF8);
            //-------------------------------------------------
            //------------tel ---------------------------
            p = fn + this.id_textBox1.Text + "_tel.txt";
            System.IO.File.WriteAllText(p, this.tel_textBox4.Text, Encoding.UTF8);
            //-------------------------------------------------
            //------------cell ---------------------------
            p = fn + this.id_textBox1.Text + "_cell.txt";
            System.IO.File.WriteAllText(p, this.cell_textBox5.Text, Encoding.UTF8);
            //-------------------------------------------------
            //------------email--------------------
            p = fn + this.id_textBox1.Text + "_email.txt";
            System.IO.File.WriteAllText(p, this.email_textBox6 .Text, Encoding.UTF8);
            //-------------------------------------------------
            //------------address ---------------------------
            p = fn + this.id_textBox1.Text + "_add.txt";
            System.IO.File.WriteAllText(p, this.add_textBox7.Text, Encoding.UTF8);
            //-------------------------------------------------
            //------------comment ---------------------------
            p = fn + this.id_textBox1.Text + "_comm.txt";
            System.IO.File.WriteAllText(p, this.comm_textBox8 .Text, Encoding.UTF8);
            //-------------------------------------------------
            MessageBox.Show("Saved!");
        }

        private void Reg_data_Load(object sender, EventArgs e)
        {
            this.Info_gbox.Enabled = false;
        }
    }
}
