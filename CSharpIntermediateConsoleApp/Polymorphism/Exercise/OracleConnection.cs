using System;

namespace CSharpIntermediateConsoleApp.Polymorphism.Exercise
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {

        }

        public override void Open()
        {
            Console.WriteLine("Oracle connection opened");
        }

        public override void Close()
        {
            Console.WriteLine("Oracle connection closed");
        }
    }
}
