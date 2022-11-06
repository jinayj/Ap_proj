using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login_App
{
    public partial class Form1 : Form 
    {
        Credentials c = new Credentials();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string uservalid = textBox1.Text;
            string passvalid = textBox2.Text;

            if (c.getUsername() != uservalid)
            {
                MessageBox.Show("Invalid Credentials");
            }
            else
            {
                MessageBox.Show("Login Successful");
                Form2 frm2 =new Form2(c);
                frm2.Show();
            }
        }
    }
}
