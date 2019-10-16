using CSharpIntermediateConsoleApp.Polymorphism.Abstract;
using CSharpIntermediateConsoleApp.Polymorphism.Exercise;

namespace CSharpIntermediateConsoleApp.Polymorphism
{
    class CallerClass
    {
        public void OverridingExample()
        {
            var caller = new Overriding.BadlyStructured.Caller();
            caller.Call();

            var callerTwo = new Overriding.ProperlyStructured.Caller();
            callerTwo.Call();
        }

        public void AbstractExample()
        {
            //var shape = new Shape(); We cannot instantiate Shape class(which makes sense as it's too abstract)
            var circle = new Circle();
            circle.Draw();
            circle.Copy(); //Calling non abstract member of abstract class

            var rectangle = new Rectangle();
            rectangle.Draw();
        }

        public void Exercise()
        {
            var dBCommand = new DbCommand(new SqlConnection("connection string: username: abc password: XYZ"), "delete data from table");
            dBCommand.Execute();
            dBCommand.DbConnection.Open();
        }
    }
}
