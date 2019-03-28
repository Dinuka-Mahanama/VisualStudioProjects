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
    public partial class LecMain : Form
    {
        String Password;

        public LecMain(String Password)
        {
            InitializeComponent();
            this.Password = Password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            this.Hide();
            f2.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LecDetails f2 = new LecDetails(Password);
            this.Hide();
            f2.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LecStudView f2 = new LecStudView(Password);
            this.Hide();
            f2.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LecStudEdit f2 = new LecStudEdit(Password);
            this.Hide();
            f2.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CorDetails f2 = new CorDetails(Password, "lec");
            this.Hide();
            f2.Show(this);
        }
    }
}
