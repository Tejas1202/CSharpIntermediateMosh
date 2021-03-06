﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConsoleApp.Polymorphism.Exercise
{
    // DbCommand doesn't care about how a connection is open or closed, it's not the responsibilty of DbCommand, all it cares is to send
    // an instruction to the database
    class DbCommand
    {
        public DbConnection DbConnection { get; }
        public string SqlCommand { get; set; }

        public DbCommand(DbConnection dbConnection, string sqlCommand)
        {
            if (dbConnection is null)
                throw new ArgumentNullException( "Connection object cannot be null");
            if (string.IsNullOrWhiteSpace(sqlCommand))
                throw new ArgumentException("command cannot be null or empty or whitespace");

            DbConnection = dbConnection;
            SqlCommand = sqlCommand;
        }

        public void Execute()
        {
            DbConnection.Open();
            Console.WriteLine("{0} query executed successfully",SqlCommand);
            DbConnection.Close();
        }
        
    }
}
