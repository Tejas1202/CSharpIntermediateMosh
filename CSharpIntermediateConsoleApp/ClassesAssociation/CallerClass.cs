using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediateConsoleApp.ClassesAssociation
{
    class CallerClass
    {
        public void InheritanceExample()
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
        }

        public void CompositionExample()
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
