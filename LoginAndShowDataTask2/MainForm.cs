using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndShowDataTask2
{
    public partial class MainForm : Form
    {
        private SqlConnection con = new SqlConnection("server = localhost; Initial Catalog=HasanTask2; Integrated Security=True");

        public string Username = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            lblUsername.Text = Username;
            ShowDatas();
        }

        private void ShowDatas()
        {
            string cmdString = "SELECT * from Student";
            SqlCommand cmd = new SqlCommand(cmdString, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            con.Open();
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }


    }
}
