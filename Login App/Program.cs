using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login_App
{

    public class Credentials
    {

        private string password = "ilham";
        private string username = "Ilham";
        private string balance = "20000";
        private string lastaccess;
        private string benef="";
        private string trans="";
        

        public string getUsername()
        {
            return this.username;
        }
        public void setBenef(string val)
        {
            this.benef = val;
        }
        public string getBenef()
        {
            return benef;
        }
        public void setTrans(string val)
        {
            this.trans = val;
        }
        public string getTrans()
        {
            return trans;
        }

        public string getPassword()
        {
            return this.password;
        }
        public string getBalance()
        {
            return this.balance;
        }
        public void setBalance(string n)
        {
            this.balance=n;
        }
        public void setlastAccess(string val)
        {
            this.lastaccess = val;
        }
    }
    
  

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        ///  private string username="Ilham";
       
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
