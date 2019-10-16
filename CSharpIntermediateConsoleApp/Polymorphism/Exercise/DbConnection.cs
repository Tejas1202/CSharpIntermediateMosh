using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConsoleApp.Polymorphism.Exercise
{
    abstract class DbConnection
    {
        public string ConnectionString { get; }
        public TimeSpan TimeOut { get; set; }

        public DbConnection(string connectionString)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("connection string cannot be null or empty", nameof(connectionString));

            ConnectionString = connectionString;
        }

        public abstract void Open();

        public abstract void Close();
    }
}
