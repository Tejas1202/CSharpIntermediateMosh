using System;

namespace CSharpIntermediateConsoleApp.Interfaces.Extensibility
{
    //ex. DbMigrator is used for migrating the database and we would like to log some messages as the database is being migrated
    public class DbMigrator
    {
        //Now as in case of restaurant, the restaurant needs a chef, whether it's John/Smith/Mary it doesn't matter as long as they all fulfill the given standard
        //Similarly DbMigrator doesn't care who is the actual logger, an instance of any class that implements this interface can be passed in the constructor here
        //hence, there's no coupling between the DbMigrator here and that concrete class
        private readonly ILogger _logger;

        //Dependency injection (in the constructor, we're defining the dependencies for this DbMigrator class and later in the main method, 
        //we're going to specify a concrete class that implements this interface)
        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            #region w/o extensibility (now let's say tomorrow we want to use file/database instead of console,
            //we've to comeback to this method and change it, which means this class has to be recompiled and redeployed

            Console.WriteLine("Migration started at {0}", DateTime.Now);

            //Details of migrating the database

            Console.WriteLine("Migration finished at {0}", DateTime.Now);
            #endregion

            #region with extensibility
            _logger.LogInfo("Migration started at {0}" + DateTime.Now);

            //Details of migrating the database

            _logger.LogInfo("Migration finished at {0}" + DateTime.Now);
            #endregion

        }
    }
}