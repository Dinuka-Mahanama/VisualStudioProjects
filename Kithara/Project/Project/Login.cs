using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Login : Form
    {
        String adminpass = "admin";
        String password;

        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            String pass = textBox2.Text;
            password = pass;

           if (user == "admin" & pass == "admin")
            {
                AdMain f2 = new AdMain();
                this.Hide();
                f2.Show(this);
            }
            else if (user == "Lecturer")
            {
                LecMain f2 = new LecMain(password);
                this.Hide();
                f2.Show(this);
            }
            else if (user == "Student")
            {
                StuMain f2 = new StuMain(password);
                this.Hide();
                f2.Show(this);
            }
            else
            {
                string message = "ERROR";
                string title = "INVALID LOGIN DETAILS";
                MessageBox.Show(title, message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
