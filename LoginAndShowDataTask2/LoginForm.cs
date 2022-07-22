using System.Data.SqlClient;

namespace LoginAndShowDataTask2
{
    public partial class Form1 : Form
    {
        private SqlConnection con = new SqlConnection("server = localhost; Initial Catalog=HasanTask2; Integrated Security=True");
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
                query = "select * from User Where Username = '"+mtbUsername.Text+"' and Password = '"+mtbPassword.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader(); ;
                con.Close();

                if (dr.Read())
                    MessageBox.Show("Kullanýcý Adý yada Þifre hatalý...");
                else
                {
                    MainForm mainForm = new MainForm();
                    mainForm.Username = mtbUsername.Text;
                    Hide();
                    mainForm.Show();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}