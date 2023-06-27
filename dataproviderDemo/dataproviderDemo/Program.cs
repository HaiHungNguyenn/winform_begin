using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data.Common;

namespace dataproviderDemo
{
    internal static class Program
    {
       
     
        static String GetConnectionString() {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json", true, true)
                .Build();
            var strConnection = config["ConnectionString:MystoreDB"];
            return strConnection;
        }
     

        static void ViewProduct() {
            DbProviderFactory factory = SqlClientFactory.Instance;
            using DbConnection connection = factory.CreateConnection();
            if (connection == null) {
                Console.WriteLine($"Unable to create the connection object.");
            }
            connection.ConnectionString = GetConnectionString();
            connection.Open();
            DbCommand command = connection.CreateCommand();
            if(command == null)
            {
                Console.WriteLine($"Unable to create the command object.");
                return;
            }
            command.Connection = connection;
            command.CommandText = "Select ProductID, ProductName From Products";
            using DbDataReader reader = command.ExecuteReader();
            Console.WriteLine("*** Product List ***");
            while(reader.Read())
            {
                Console.WriteLine($"ProductID:{reader["ProductID"]}", $"ProductName:{reader["ProductName"]}.");
            }
            


        }
        static void Main(String[] args)
        {
            ViewProduct();
            Console.ReadLine();
        }
    }
}