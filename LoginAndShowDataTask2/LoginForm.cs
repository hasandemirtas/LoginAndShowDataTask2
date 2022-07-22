using System.Data.SqlClient;

namespace LoginAndShowDataTask2
{
    public partial class Form1 : Form
    {
        static string serverName = System.Environment.MachineName;
        private SqlConnection con = new SqlConnection("server = "+ serverName + "\\SQLEXPRESS; Initial Catalog=HasanTask2; Integrated Security=True");
        private string query = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(mtbUsername.Text) && !String.IsNullOrEmpty(mtbPassword.Text))
            {
                query = "select * from users Where username = '"+mtbUsername.Text+"' and password = '"+mtbPassword.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader(); ;

                if (!dr.Read())
                    MessageBox.Show("Kullanýcý Adý yada Þifre hatalý...");
                else
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Username = mtbUsername.Text;
                    mainForm.ShowDialog();
                    Hide();

                }
                con.Close();

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}