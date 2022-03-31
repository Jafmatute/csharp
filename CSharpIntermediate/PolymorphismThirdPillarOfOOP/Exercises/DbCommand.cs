using System;

namespace CSharpIntermediate.PolymorphismThirdPillarOfOOP.Exercises
{
    public class DbCommand
    {
        private readonly DbConnection _stringConnection;
        private readonly string _queryString;

        public DbCommand(DbConnection stringConnection, string queryString)
        {
            _stringConnection = stringConnection;
            _queryString = queryString;
        }



        public void Execute()
        {
            if (string.IsNullOrEmpty(_queryString))
                throw new InvalidOperationException("query string null or empty");

            _stringConnection.DbConnect();
            Console.WriteLine("command execute " + _queryString);
            _stringConnection.DbCloseConnect();

        }
    }
}