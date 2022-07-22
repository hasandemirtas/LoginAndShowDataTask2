namespace LoginAndShowDataTask2
{
    public partial class Form1 : Form
    {
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
                if(mtbUsername.Text != "alica")
                {
                    MessageBox.Show("Kullanýcý Adý Yanlýþ...");
                }
                else if (mtbPassword.Text != "35688")
                {
                    MessageBox.Show("Þifre Yanlýþ...");
                }
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