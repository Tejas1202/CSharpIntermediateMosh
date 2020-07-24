namespace CSharpIntermediateConsoleApp.ClassesAssociation
{
    class DbMigrator
    {
        // Has-A relationship. DBMigrator has a Logger field
        // example of code re-use by Composition relation between two classes
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating table schema etc..");
        }
    }
}
