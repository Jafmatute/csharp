using System;

namespace CSharpIntermediate.PolymorphismThirdPillarOfOOP.Exercises
{
    public class OracleConnection : DbConnection
    {
        private readonly string _stringConnection;

        public OracleConnection(string stringConnection) : base(stringConnection)
        {
            _stringConnection = stringConnection;
        }

        public override void DbConnect()
        {
            Console.WriteLine("database oracle connected success");
        }

        public override void DbCloseConnect()
        {
            Console.WriteLine("Database Oracle close connection");
        }
    }
}