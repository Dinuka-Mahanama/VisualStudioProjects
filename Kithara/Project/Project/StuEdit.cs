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
    public partial class StuEdit : Form
    {
        public StuEdit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String StuId = textBox1.Text;
            String Name = textBox2.Text;
            String couId = textBox3.Text;
            String tel = textBox1.Text;
            String asmark = textBox2.Text;
            String exmark = textBox3.Text;

            //check qury
            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            String Query = "UPDATE student.studetmain SET Name=\""+Name+ "\", StuTel="+tel+ ",CorId=\"" +couId+ "\",MarkAs=" +asmark+ ", MarkEx=" +exmark+ " WHERE StuId='"+StuId+"'";

            try
            {
                MySqlCommand myCommand = new MySqlCommand(Query, cn);
                cn.Open();
                myCommand.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String StuId = textBox1.Text;

            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            String Query = "DELETE FROM student.studetmain WHERE StuId=\"" + StuId+"\"";

            try
            {
                MySqlCommand myCommand = new MySqlCommand(Query, cn);
                cn.Open();
                myCommand.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String StuId = textBox1.Text;
            String Name = textBox2.Text;
            String couId = textBox3.Text;
            String tel = textBox4.Text;
            String asmark = textBox5.Text;
            String exmark = textBox6.Text;

            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            String Query = "INSERT INTO student.studetmain(StuId, Name, MarkAs, MarkEx, StuTel, CorId) VALUES (\""+StuId+"\",\""+Name+"\","+asmark+","+exmark+","+tel+",\""+couId+"\")";

            try
            {
                MySqlCommand myCommand = new MySqlCommand(Query, cn);
                cn.Open();
                myCommand.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdMain f2 = new AdMain();
            this.Hide();
            f2.Show(this);
        }
    }
}
