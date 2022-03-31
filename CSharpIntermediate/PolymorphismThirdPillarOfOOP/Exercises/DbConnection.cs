using System;

namespace CSharpIntermediate.PolymorphismThirdPillarOfOOP.Exercises
{
    public abstract class DbConnection
    {
        private readonly string _connectionString;

        protected TimeSpan TimeOut;


        protected DbConnection(string connectionString)
        {
            _connectionString = connectionString;
            TimeOut = TimeSpan.FromMilliseconds(1000);
            ValidationDbConnection();
        }

        public abstract void DbConnect();

        public abstract void DbCloseConnect();

        private void ValidationDbConnection()
        {

            if (TimeOut > TimeSpan.FromMilliseconds(1000)) throw new InvalidOperationException("No response, please try again");

            if (string.IsNullOrEmpty(_connectionString)) throw new InvalidOperationException("string connect null or empty");
        }
    }
}
