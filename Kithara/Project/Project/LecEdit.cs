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
    public partial class LecEdit : Form
    {
        public LecEdit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String LecId = textBox1.Text;
            String Name = textBox2.Text;
            String tel = textBox3.Text;
            String qual = textBox6.Text;
            String sala = textBox5.Text;

            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            String Query = "INSERT INTO student.lecture(LecId,LecName,LecTel,Qual,Salary) VALUES (\"" + LecId + "\",\"" + Name + "\"," + tel + ",\"" +qual+ "\","+tel+")";

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
            String LecId = textBox1.Text;

            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            String Query = "Delete FROM student.lecture where LecId=\"" + LecId+ "\"";

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
