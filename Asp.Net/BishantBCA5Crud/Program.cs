using System;
using System.Data.SqlClient;

namespace DotNetSql_tasks
{
    class DatabaseTasks
    {
        public void ConnectAndInsert()
        {
            SqlConnection conn;

            try
            {
                //create connection
                string connStr = "server=DESKTOP-HD527K7\\SQLEXPRESS; database=Student; integrated security=SSPI; TrustServerCertificate=TRUE;";

                //open conn
                conn = new SqlConnection(connStr);
                conn.Open();

                Console.WriteLine("Connection Established Successfully");

                //INSERT
                string insertQuery = "INSERT INTO person_info(id, name, phone) " +
                                     "VALUES (1010, 'Aarav', '9801234567'), " +
                                     "(1011, 'Sujan', '9807654321')," +
                                     "(1012, 'Riya', '9812345678'), " +
                                     "(1013, 'Suman', '9818765432')";



                SqlCommand cmd = new SqlCommand(insertQuery, conn);

                int n = cmd.ExecuteNonQuery();

                Console.WriteLine("Number of rows inserted: " + n);

                //UPDATE query: Update name for id = 1012 to 'Ritika'


               string updateQuery = "UPDATE person_info SET name = 'Ritika' WHERE id = 1012";
               SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                int updateCount = updateCmd.ExecuteNonQuery();
                Console.WriteLine("Number of rows updated: " + updateCount);


                //DELETE query: Delete record with id = 1013

                string deleteQuery = "DELETE FROM person_info WHERE id = 1012";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, conn);
                int deleteCount = deleteCmd.ExecuteNonQuery();
                Console.WriteLine("Number of rows deleted: " + deleteCount); 
                Console.WriteLine("Lab 2.25 / Bishant Kayastha / Roll No.: 5");


                // READ data
                string selectQuery = "SELECT id, name, phone FROM person_info";
                SqlCommand selectCmd = new SqlCommand(selectQuery, conn);
                SqlDataReader reader = selectCmd.ExecuteReader();

                // Looping through each record
                Console.WriteLine("ID\tName\tPhone");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["id"]}\t {reader["name"]}\t {reader["phone"]}");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
           
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DatabaseTasks dbTest = new DatabaseTasks();
            dbTest.ConnectAndInsert();
        }
    }
}
