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
    public partial class StuDetails : Form
    {
        String Password;

        public StuDetails(String Password)
        {
            InitializeComponent();
            this.Password = Password;
        }

        private void StuDetails_Load(object sender, EventArgs e)
        {
            MySqlConnection cn = new MySqlConnection("datasource=localhost;port=3306;username=root;password=");
            String Query = "SELECT * FROM student.studetmain where StuId=\""+Password+"\"";
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

        private void Back_Click(object sender, EventArgs e)
        {
            StuMain f2 = new StuMain("");
            this.Hide();
            f2.Show(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
