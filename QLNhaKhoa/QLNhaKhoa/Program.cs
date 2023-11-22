using QLNhaKhoa.Dentist_form;
using System.Data.SqlClient;

namespace QLNhaKhoa
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            SqlConnection sqlCon = new SqlConnection("Data Source=HUY;Initial Catalog=Nhom3_QLNhaKhoa;Integrated Security=True;TrustServerCertificate=True");
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}