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
    public partial class CorEdit : Form
    {
        public CorEdit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdMain f2 = new AdMain();
            this.Hide();
            f2.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String CorId = textBox1.Text;
            String Name = textBox2.Text;
            String LecId = textBox3.Text;
            String fee = textBox6.Text;
            String dec = textBox5.Text;

            //check qury
            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            String Query = "INSERT INTO student.course(CurId,CurName,Fees,LecId,Descp) VALUES (\"" + CorId + "\",\"" +Name+ "\","+ fee +",\"" + LecId + "\",\"" +dec + "\")";

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
            String CorId = textBox1.Text;

            //check qury
            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            String Query = "DELETE FROM student.course where CurId=\"" + CorId + "\"";

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
    }
}
