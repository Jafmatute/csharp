using System;

namespace CSharpIntermediate.Interfaces
{
    public class DbMigration
    {
        private readonly ILogger _logger;

        public DbMigration(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.LogInfo("Migration started at {0} " + DateTime.Now);


            //details of migrating the database
            _logger.LogInfo("Migration finished at {0} " + DateTime.Now);

        }
    }
}