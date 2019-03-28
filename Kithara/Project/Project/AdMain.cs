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
    public partial class AdMain : Form
    {
        public AdMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login f2 = new Login();
            this.Hide();
            f2.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LecStudView f2 = new LecStudView("admin");
            this.Hide();
            f2.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LecDetails f2 = new LecDetails("admin");
            this.Hide();
            f2.Show(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CorDetails f2 = new CorDetails("admin","admin");
            this.Hide();
            f2.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StuEdit f2 = new StuEdit();
            this.Hide();
            f2.Show(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LecEdit f2 = new LecEdit();
            this.Hide();
            f2.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CorEdit f2 = new CorEdit();
            this.Hide();
            f2.Show(this);
        }
    }
}
