using System;
using Microsoft.Data.SqlClient;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;
        string connStr = "Server=.\\SQLEXPRESS01;Database=TestADO;Trusted_Connection=True;TrustServerCertificate=True";

        SqlConnection conn = new SqlConnection(connStr);

        try
        {
            conn.Open();
            Console.WriteLine("Ket noi thanh cong!");

            string sql = "SELECT * FROM SinhVien";
            SqlCommand cmd = new SqlCommand(sql, conn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Console.WriteLine("ID: " + reader["id"]);
                Console.WriteLine("Name: " + reader["name"]);
                Console.WriteLine("Age: " + reader["age"]);
                Console.WriteLine("-------------------");
            }

            reader.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Loi: " + ex.Message);
        }
        finally
        {
            conn.Close();
        }
    }
}