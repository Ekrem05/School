using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Connection
{
    class Program
    {
        public static List<string> GetTableNames(SqlConnection connection)
        {
            List<string> tables = new List<string>();
            using (connection)
            {

                
                tables = connection.GetSchema("Tables").AsEnumerable().Select(s => s[2].ToString()).ToList();
                
            }
                     
            return tables;
        }
 
        public static void PrintTable(List<string> list)
        {
            int count = 1;
            foreach (var item in list)
            {

                Console.WriteLine($"{count}. {item}");
                count++;
            }
        }

        static void Main(string[] args)
        {
            
            string command = string.Empty;
            Console.WriteLine("Enter the number of the command you want:");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Select");
            Console.WriteLine("3. Delete");

            while ((command = Console.ReadLine()) != "End")
            {
                SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=BeeShop;Integrated Security=true");
                conn.Open();
                string[] split = command.Split();
                int action = int.Parse(split[0]);
                if (action == 1)
                {   //Insert Products 3 rows
                    // product_name, price, stock_left
                    Console.WriteLine("Tables");
                    int count = 1;
                    List<string> list = GetTableNames(conn);
                    
                    PrintTable(list);
                    
                    string table = Console.ReadLine();
                    Console.Write("How many rows will you insert?: ");
                    int rowCount = int.Parse(Console.ReadLine());
                    
                    for (int i = 0; i < rowCount; i++)
                    {
                        Console.Write("Enter the name of the product:");
                        string productName = Console.ReadLine();
                        Console.Write("Enter the price of the product:");
                        double price = double.Parse(Console.ReadLine());
                        Console.Write("Enter the count of the product in reserve:");
                        int stock = int.Parse(Console.ReadLine());
                        conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=BeeShop;Integrated Security=true");
                        conn.Open();
                        SqlCommand inserter = new SqlCommand($"Insert into {table}(product_name,price,stock_left) values('{productName}',{price},{stock})", conn);
                        
                        var executeInserter = inserter.ExecuteNonQuery();
                        Console.WriteLine($"Row/s affected: {executeInserter}");
                    }
                }
                else if (action == 3)
                {
                    Console.Write("Enter a table: ");
                    List<string> list = GetTableNames(conn);
                    PrintTable(list);
                    string table = Console.ReadLine();
                    Console.Write("Enter the name of the product: ");
                    string name = Console.ReadLine();
                    conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=BeeShop;Integrated Security=true");
                    conn.Open ();
                    SqlCommand deleter = new SqlCommand($"Delete from {table} Where product_name='{name}'", conn);
                    Console.WriteLine("Row/s affected: {0}", deleter.ExecuteNonQuery());
                }
                else if (action == 2)
                {
                    Console.WriteLine("Enter a table: ");
                    List<string> list = GetTableNames(conn);
                    PrintTable(list);
                    string table = Console.ReadLine();
                    conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=BeeShop;Integrated Security=true");
                    conn.Open();
                    SqlCommand selectAll = new SqlCommand($"Select * from {table}", conn);
                    SqlDataReader reader = selectAll.ExecuteReader();
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        Console.Write($"{reader.GetName(i)} ");
                    }
                    Console.WriteLine();
                    while (reader.Read())
                    {
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            Console.Write($" {reader[i]} ");
                        } 
                        Console.WriteLine();

                    }
                    reader.Close();
                }
                Console.WriteLine("Enter the number of the command you want:");
                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Select");
                Console.WriteLine("3. Delete");
                Console.WriteLine("\"End\" to close");
                conn.Close();
            }


            


        }


    }
}