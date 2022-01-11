﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbConnection
{
    public  class OpenConnection
    {
        private string _connectionString;
        protected internal OpenConnection()
        {
            _connectionString = "Data Source=(localdb)\\ProjectModels;Initial Catalog=WebApiVersion1;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public OpenConnection(string ConnectionString)
        {
            _connectionString = ConnectionString;
        }
        public void TestDisplay(string AuthenticateCode)
        {
            if(AuthenticateCode=="qwerty12345678")
                Console.WriteLine(_connectionString);
            else
                    Console.WriteLine("You cant access this field");


        }
        public bool IsConnected()
        {
            try
            {
                SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                connection.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
