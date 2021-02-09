using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Reflection;
using System.Configuration;

namespace HomeWork6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create Database;

            // Если база не создана, то создать
            if (!ExistDatabase())
            {
                string queryString;
                using (SqlConnection connection = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Integrated security=SSPI;database=master"))
                {
                    string path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);

                    queryString = $@"CREATE DATABASE Story ON PRIMARY 
                     (NAME = Story, 
                     FILENAME = '{path}\\Story.mdf', 
                     SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) 
                     LOG ON (NAME = Story_Log, 
                     FILENAME = '{path}\\StoryLog.ldf', 
                     SIZE = 1MB, 
                     MAXSIZE = 5MB, 
                     FILEGROWTH = 10%)
                    COLLATE Cyrillic_General_CI_AS";

                    SqlCommand command = new SqlCommand(queryString, connection);
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("DataBase is Created Successfully");
                }
            }

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["StoryConnection"].ConnectionString;

               
                string queryString = "CREATE TABLE Stories" +
                "(Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY," +
                "Name NVARCHAR(50) NOT NULL, Description NVARCHAR(255))";

                connection.Open();
                var command = new SqlCommand(queryString, connection);
                if (!ExistTable())
                {
                    command.ExecuteNonQuery();
                }

                queryString = @"INSERT INTO Stories(Name, Description) 
                    VALUES ('История 1', 'Описание 1'),
                    ('История 2', NULL),
                    ('История 3', 'Описание 3'),
                    ('История 4', 'Описание 4'),
                    ('История 5', NULL),
                    ('История 6', 'Описание 6'),
                    ('История 7', NULL)";

                command = new SqlCommand(queryString, connection);
                command.ExecuteNonQuery();


                queryString = "Select * from Stories";
                command = new SqlCommand(queryString, connection);

                var reader = command.ExecuteReader();

                while(reader.Read())
                {
                    Console.WriteLine($"{reader["Name"]} {reader["Description"]}");
                }
            }

            Console.ReadKey();
        }

        private static bool ExistDatabase()
        {
            string connString = "Server =(localdb)\\MSSQLLocalDB;Integrated security=SSPI;database=master";

            string cmdText = "select Count(*) from sysdatabases where name='Story'";

            bool bRet = false;

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCmd = new SqlCommand(cmdText, sqlConnection))
                {
                    int nRet = (int)sqlCmd.ExecuteScalar();
                    if (nRet <= 0)
                    {
                        bRet = false;
                    }
                    else
                    {
                        bRet = true;
                    }
                }
            }
            return bRet;
        }

        private static bool ExistTable()
        {
            string connString = ConfigurationManager.ConnectionStrings["StoryConnection"].ConnectionString;

            string cmdText = "SELECT Count(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'Stories'";

            bool bRet = false;

            using (SqlConnection sqlConnection = new SqlConnection(connString))
            {
                sqlConnection.Open();
                using (SqlCommand sqlCmd = new SqlCommand(cmdText, sqlConnection))
                {
                    int nRet = (int)sqlCmd.ExecuteScalar();
                    if (nRet <= 0)
                    {
                        bRet = false;
                    }
                    else
                    {
                        bRet = true;
                    }
                }
            }
            return bRet;
        }
    }
}
