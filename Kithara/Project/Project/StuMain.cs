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
    public partial class StuMain : Form
    {
        String Password;
        public StuMain(String Password)
        {
            InitializeComponent();
            this.Password = Password;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            this.Hide();
            f2.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StuDetails f2 = new StuDetails(Password);
            this.Hide();
            f2.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CorDetails f2 = new CorDetails(Password, "stu");
            this.Hide();
            f2.Show(this);
        }
    }
}
