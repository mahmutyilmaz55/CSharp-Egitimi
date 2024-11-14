using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create-Read-Update-Delete
            Console.WriteLine("************* Menü Sipariş İşlem Paneli *************");
            Console.WriteLine();

            #region Kategori ekleme İşlemi
            //Console.WriteLine("-----------------------------------------------------");
            //Console.Write("Eklemek İstediğiniz Kategori Adı : ");
            //string categoryName = Console.ReadLine();

            //SqlConnection connect = new SqlConnection("Data Source=DESKTOP-0UCP9RJ\\SQLEXPRESS;initial Catalog=EgitimKampiDb; integrated security=true");

            //connect.Open();
            //SqlCommand command = new SqlCommand("insert into TblCategory(CategoryName) values (@p1)", connect);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connect.Close();
            //Console.Write("Kategori Eklendi.");
            //
            #endregion

            #region Ürün Ekleme İşlemi

            //string productName;
            //decimal productPrice;


            //Console.Write("Ürün Adı : ");
            //productName = Console.ReadLine();
            //Console.Write("Ürüm Fiyatı : ");
            //productPrice = decimal.Parse(Console.ReadLine());


            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0UCP9RJ\\SQLEXPRESS;initial Catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct(ProductName,ProductPrice,ProductStatus) values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Eklemesi Başarılı");
            #endregion

            #region Ürün Listeleme İşlemi
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0UCP9RJ\\SQLEXPRESS;initial Catalog=EgitimKampiDb; integrated security=true");

            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * from TblProduct",connection);
            //SqlDataAdapter da = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //da.Fill(dataTable);
            //connection.Close();

            //foreach(DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Ürün silme işlemi


            //Console.Write("Silinecek ürün Id : ");
            //int productId = int.Parse(Console.ReadLine());
            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0UCP9RJ\\SQLEXPRESS;initial Catalog=EgitimKampiDb; integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Silme Yapıldı.");
            #endregion

            #region Ürün Güncelleme İşlemi
            Console.WriteLine("Güncelleneck Ürün Id : ");
            int productId = int.Parse(Console.ReadLine());

            Console.WriteLine("Güncellenecek Ürün Ad : ");
            String productName = Console.ReadLine();

            Console.WriteLine("Güncellenecek Ürün Fiyatı : ");
            decimal productPrice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source=DESKTOP-0UCP9RJ\\SQLEXPRESS;initial Catalog=EgitimKampiDb; integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Update TblProduct SET ProductName=@productName,ProductPrice=@productPrice WHERE ProductId=@productId",connection);
            command.Parameters.AddWithValue("@productId", productId);
            command.Parameters.AddWithValue("@productName", productName);
            command.Parameters.AddWithValue("@productPrice", productPrice);
            command.ExecuteNonQuery();

            Console.WriteLine("Güncelleme Başarılı");
            #endregion
            Console.ReadLine();
        }
    }
}
