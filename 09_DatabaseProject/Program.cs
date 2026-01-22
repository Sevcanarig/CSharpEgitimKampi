using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tableNumber;
            Console.WriteLine("**********  Hoşgeldiniz  **********");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış yap");
            
            Console.WriteLine("Lütfen yapmak istediğiniz tablo numarasını giriniz: ");
             tableNumber = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True;TrustServerCertificate=True");

            connection.Open();
            SqlCommand command = new SqlCommand("select * From TblCategory",connection);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
    
