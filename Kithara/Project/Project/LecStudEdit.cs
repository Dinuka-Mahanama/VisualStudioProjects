using MySql.Data.MySqlClient;
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
    public partial class LecStudEdit : Form
    {
        String password;

        public LecStudEdit(String password)
        {
            InitializeComponent();
            this.password = password;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LecMain f2 = new LecMain(password);
            this.Hide();
            f2.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String StuId = textBox1.Text;
            String AssMark = textBox2.Text;
            String ExMark = textBox3.Text;

            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            String Query = "UPDATE student.studetmain SET MarkAs=" + AssMark+", MarkEx="+ExMark+" WHERE StuId=\""+StuId+"\"";

            try
            {
                MySqlCommand myCommand = new MySqlCommand(Query, cn);
                cn.Open();
                myCommand.ExecuteNonQuery();
                cn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
