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
            using (SqlConnection conn = connection)
            {
                if (conn.State == ConnectionState.Open)
                {
                    return conn.GetSchema("Tables").AsEnumerable().Select(s => s[2].ToString()).ToList();
                }
            }
            //Add some error-handling instead !
            return new List<string>();
        }
        public static void PrintTable(List<string> list, SqlConnection conn)
        {
            int count = 0;
            foreach (var item in GetTableNames(conn))
            {

                Console.WriteLine($"{count}. {item}");
                count++;
            }
        }

        static void Main(string[] args)
        {
            SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=BeeShop;Integrated Security=true");
            conn.Open();
            string command = string.Empty;
            Console.WriteLine("Въведете номер на команда:");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Select");
            Console.WriteLine("3. Delete");

            while ((command = Console.ReadLine()) != "End")
            {
                string[] split = command.Split();
                int action = int.Parse(split[0]);
                if (action == 1)
                {   //Insert Products 3 rows
                    // product_name, price, stock_left
                    Console.WriteLine("Tables");
                    int count = 1;
                    List<string> list = GetTableNames(conn);
                    PrintTable(list, conn);

                    string table = Console.ReadLine();
                    Console.WriteLine("Колко записа ще въведете?");
                    int rowCount = int.Parse(Console.ReadLine());

                    for (int i = 0; i < rowCount; i++)
                    {
                        Console.WriteLine("Въведете име на продукт:");
                        string productName = Console.ReadLine();
                        Console.WriteLine("Въведете цена на продукта:");
                        double price = double.Parse(Console.ReadLine());
                        Console.WriteLine("Въведете бройката на продукта в склад:");
                        int stock = int.Parse(Console.ReadLine());
                        SqlCommand inserter = new SqlCommand($"Insert into {table}(product_name,price,stock_left) values('{productName}',{price},{stock})", conn);
                        conn.Open();
                        var executeInserter = inserter.ExecuteNonQuery();
                        Console.WriteLine($"Вкарани редове: {executeInserter}");
                    }
                }
                else if (action == 3)
                {
                    Console.WriteLine("Коя таблица?: ");
                    string table = Console.ReadLine();
                    Console.WriteLine("Въведете името на продукта: ");
                    string name = Console.ReadLine();
                    SqlCommand deleter = new SqlCommand($"Delete from {table} Where product_name='{name}'", conn);
                    Console.WriteLine("Изтрити записи: {0}", deleter.ExecuteNonQuery());
                }
                else if (action == 2)
                {
                    Console.WriteLine("Коя таблица?");
                    string table = Console.ReadLine();
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
                            Console.Write($"{reader[i]}");
                        }
                        Console.WriteLine();

                    }
                    reader.Close();
                }
                Console.WriteLine("Въведете номер на команда:");
                Console.WriteLine("1. Insert");
                Console.WriteLine("2. Select");
                Console.WriteLine("3. Delete");
                Console.WriteLine("End за край");

            }


            conn.Close();


        }


    }
}