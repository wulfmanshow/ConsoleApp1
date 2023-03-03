using System;
using System.Data.SqlClient;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            String source = @"Data Source=DESKTOP-H61STOF;Initial Catalog=Fruits; Integrated Security=True";
            SqlConnection connection = new SqlConnection(source);

            //try
            //{
            //    connection.Open();
            //    Console.WriteLine(connection.State);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("неа");
            //}
            //finally
            //{
            //    connection.Close();
            //    Console.WriteLine(connection.State);
            //}
            try 
            {
                connection.Open();
                SqlDataReader rdr = null;
                SqlCommand cndRead = new SqlCommand("Select * from Table_1", connection);
                rdr = cndRead.ExecuteReader();
                Console.WriteLine("full table:");
                while (rdr.Read())
                {                  
                    Console.WriteLine(rdr[0] + " " + rdr[1] + " " + rdr[2]+ " "+rdr[3]+"\n");
                }
                rdr.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine("error");
            }
            connection.Close();
   
            try
            {
                connection.Open();
                SqlDataReader rdr = null;
                SqlCommand cndRead = new SqlCommand("Select * from Table_1", connection);
                rdr = cndRead.ExecuteReader();
                Console.WriteLine("Names:");
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0] +"\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error");
            }
            connection.Close();
            try
            {
                connection.Open();
                SqlDataReader rdr = null;
                SqlCommand cndRead = new SqlCommand("Select * from Table_1", connection);
                rdr = cndRead.ExecuteReader();
                Console.WriteLine("Collors:");
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[2] + "\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error");
            }
            connection.Close();
            try
            {
                connection.Open();
                SqlDataReader rdr = null;
                SqlCommand cndRead = new SqlCommand("Select Max(calories) from Table_1", connection);
                rdr = cndRead.ExecuteReader();
                Console.WriteLine("Max callories:");
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }
            }
                
            catch (Exception ex)
            {
                Console.WriteLine("error");
            }
            connection.Close();

            try
            {
                connection.Open();
                SqlDataReader rdr = null;
                SqlCommand cndRead = new SqlCommand("Select Min(calories) from Table_1", connection);
                rdr = cndRead.ExecuteReader();
                Console.WriteLine("Min callories:");
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("error");
            }
            connection.Close();
            try
            {
                connection.Open();
                SqlDataReader rdr = null;
                SqlCommand cndRead = new SqlCommand("Select AVG(calories) from Table_1", connection);
                rdr = cndRead.ExecuteReader();
                Console.WriteLine("Average callories:");
                while (rdr.Read())
                {
                    Console.WriteLine(rdr[0]);
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine("error");
            }
            connection.Close();
            int a = Convert.ToInt32(Console.ReadLine());

        }
    }
}
