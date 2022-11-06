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
    public partial class Form3 : Form
    {
        Credentials c;
        public Form3(Credentials c)
        {
            InitializeComponent();
            this.c = c;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string benef = textBox1.Text;
            string amount = textBox2.Text;
            int amt =Int16.Parse(c.getBalance());
            int tot = amt - Int16.Parse(amount);
            String put = tot.ToString();
            c.setBalance(put);
            c.setTrans(amount);
            c.setBenef(benef);
            MessageBox.Show("Transfer successful!");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
