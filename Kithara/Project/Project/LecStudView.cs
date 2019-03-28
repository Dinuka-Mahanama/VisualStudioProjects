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
    public partial class LecStudView : Form
    {
        String Passw;

        public LecStudView(String Passw)
        {
            InitializeComponent();
            this.Passw = Passw;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            if (Passw == "admin")
            {
                AdMain f2 = new AdMain();
                this.Hide();
                f2.Show(this);
            }
            else
            {
                LecMain f2 = new LecMain(Passw);
                this.Hide();
                f2.Show(this);
            }
        }

        private void LecStudView_Load(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            String Query = "SELECT StuId, Name, MarkAs, MarkEx, StuTel, CorId FROM student.studetmain, student.course where studetmain.CorId=student.course.CurId AND course.LecId=\"" + Passw + "\"";

            if (Passw == "admin")
            {
                Query = "SELECT * FROM student.studetmain";
            }

            MySqlDataAdapter mda = new MySqlDataAdapter(Query, cn);

            cn.Open();
            try
            {
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
