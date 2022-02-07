using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace combo_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
              string t;
             t = this.textBox1.Text;
            if (t=="")
            {
                MessageBox.Show("Hi;You can't enter empty name!!!");
                return;
            }
            this.comboBox1.Items.Add(this.textBox1.Text );
            this.itm_count_label3.Text = this.comboBox1.Items.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 si;
            si = this.comboBox1.SelectedIndex;

            this.comboBox1.Items.RemoveAt(si);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.index_label2.Text = this.comboBox1.SelectedIndex.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.comboBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.itm_count_label3.Text = this.comboBox1.Items.Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Int32 fi;
           fi= this.comboBox2.FindStringExact(this.search_textBox2.Text);
           
           
            if (fi == -1)

            {
                MessageBox.Show("Not Found!Try Again!");
            }
            else
            {
                this.Text = fi.ToString();
               this.comboBox2.SelectedIndex = fi;
            }
        }
    }
}
