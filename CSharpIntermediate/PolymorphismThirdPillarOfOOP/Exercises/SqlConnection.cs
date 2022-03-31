using System;

namespace CSharpIntermediate.PolymorphismThirdPillarOfOOP.Exercises
{
    public class SqlConnection : DbConnection
    {
        private readonly string _stringConnection;

        public override void DbConnect()
        {

            Console.WriteLine("database Sql server connected success");
        }

        public override void DbCloseConnect()
        {
            Console.WriteLine("Database Sql server close connection");
        }

        public SqlConnection(string stringConnection) : base(stringConnection)
        {
            _stringConnection = stringConnection;
        }
    }
}