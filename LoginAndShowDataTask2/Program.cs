


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
                SqlConnection con = new SqlConnection("server=localhost; Initial Catalog=master; Integrated Security=True");
                SqlCommand cmd = new SqlCommand(cmdString, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                con = new SqlConnection("server=localhost; Initial Catalog=HasanTask2; Integrated Security=True");
                cmdString = "create table User"
                            + "(Id int primary key identity,"
                            + "Username varchar(30),"
                            + "Password varchar(30))"
                            + "insert into User values('alica','35688')"
                            + "create table Student"
                            + "(Id int primary key identity,"
                            + "Name varchar(30),"
                            + "Surname varchar(30))"
                            + "insert into Student values"
                            + "('Ali','Veli'),"
                            + "('Mehmet', 'Bra'),"
                            + "('Ayþe', 'Bra'),"
                cmd = new SqlCommand(cmdString, con);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch(Exception e)
            {

            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }


    }
}