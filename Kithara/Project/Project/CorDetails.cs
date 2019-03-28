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
    public partial class CorDetails : Form
    {
        String Passw;
        String user;

        public CorDetails(String Passw,String user)
        {
            InitializeComponent();
            this.Passw = Passw;
            this.user = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Passw == "admin")
            {
                AdMain f2 = new AdMain();
                this.Hide();
                f2.Show(this);
            }
            if (user == "stu")
            {
                StuMain f2 = new StuMain(Passw);
                this.Hide();
                f2.Show(this);
            }
            if (user == "lec")
            {
                LecMain f2 = new LecMain(Passw);
                this.Hide();
                f2.Show(this);
            }
        }

        private void CorDetails_Load(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            String Query = "SELECT * FROM student.lecture where LecId=\"" + Passw + "\"";
            if (Passw == "admin")
            {
                Query = "SELECT * FROM student.course";
            }
            if (user == "stu")
            {
                Query = "SELECT CurId,CurName,Fees,LecId,Descp FROM student.course,student.studetmain WHERE studetmain.StuId=\""+Passw+"\" AND studetmain.CorId=CurId";
            }
            if (user == "lec")
            {
                Query = "SELECT * FROM student.course WHERE LecId=\""+Passw+"\"";
            }
            MySqlDataAdapter mda = new MySqlDataAdapter(Query, cn);


            try
            {
                cn.Open();
                DataSet ds = new DataSet();
                mda.Fill(ds, "studetmain");
                dataGridView1.DataSource = ds.Tables["studetmain"];
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
