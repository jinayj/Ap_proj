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
    public partial class Form2 : Form
    {
        Credentials c;
        public Form2(Credentials c)
        {
            InitializeComponent();
            this.c = c;
            

            label5.Text = c.getUsername();
            label6.Text = c.getBalance();
            label7.Text = "Today";
            label8.Text =(DateTime.Today).ToString();

            listBox1.Items.Add(c.getBenef() +"    " + c.getTrans());


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3(c);
            frm3.Show();
        }
    }
}
