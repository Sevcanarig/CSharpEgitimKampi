using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete

            Console.WriteLine("*****Menü Sipariş İşlem Paneli****");
            Console.WriteLine();

            Console.WriteLine("----------------------------------------");
            #region kategori ekleme işlemi
            //Console.WriteLine("Eklemek istediğiniz kategori adı:");
            //string categoryName = Console.ReadLine();

            //SqlConnection connection = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory (CategoryName) values (@p1) ", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategori ekleme işlemi başarılı.");
            //Console.Read();
            #endregion

            #region Ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            //bool productStatus;
            //Console.WriteLine("Ürün adı : ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı:");

            //productPrice = decimal.Parse(Console.ReadLine());

            //productStatus = true;

            //SqlConnection connection = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated security=True");

            //connection.Open();

            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName, ProductPrice, ProductStatus) values (@productName, @productPrice, @productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", productStatus);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün eklemesi başarılı :)");

            //Console.Read();
            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable datatable = new DataTable();
            //adapter.Fill(datatable);

            //foreach (DataRow row in datatable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();
            #endregion

            #region Ürün Silme İşlemi
            //Console.Write("Silinecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            //connection.Open();

            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();

            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı!");


            #endregion

            #region Ürün Güncelleme İşlemi
            Console.Write("Güncellenecek Ürün Id: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Güncellenecek Ürün Adı: ");
            string productName = Console.ReadLine();

            Console.Write("Güncellenecek Ürün Fiyatı: ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=PC\\SQLEXPRESS;Initial Catalog=EgitimKampiDb;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName, ProductPrice=@productPrice Where ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.Parameters.AddWithValue("@productId", productId);
            command.ExecuteNonQuery();
            connection.Close();
            Console.WriteLine("Güncelleme işlemi yapıldı!");
            #endregion
        }
    }
}
