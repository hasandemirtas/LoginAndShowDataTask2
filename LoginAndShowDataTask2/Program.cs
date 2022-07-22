


using System.Data.SqlClient;

namespace LoginAndShowDataTask2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                string cmdString = "Create Database HasanTask2";
                string serverName = System.Environment.MachineName; 
                SqlConnection con = new SqlConnection("server="+serverName+"\\SQLEXPRESS; Initial Catalog=master; Integrated Security=True");
                SqlCommand cmd = new SqlCommand(cmdString, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                con = new SqlConnection("server=" + serverName + "\\SQLEXPRESS;  Initial Catalog=HasanTask2; Integrated Security=True");
                cmdString = "create table users"
                            + "(userID int primary key identity,"
                            + "username varchar(30),"
                            + "password varchar(30))"
                            + "insert into users values('alica','35688')"
                            + "create table students"
                            + "(userID int primary key identity,"
                            + "name varchar(30),"
                            + "surname varchar(30))"
                            + "insert into students values"
                            + "('Ali','Veli'),"
                            + "('Mehmet', 'Şimal'),"
                            + "('Orhan', 'veli')";
                cmd = new SqlCommand(cmdString, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {

            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }


    }
}