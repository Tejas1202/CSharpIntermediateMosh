using System.IO;

namespace CSharpIntermediateConsoleApp.Interfaces.Extensibility
{
    class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = path;
        }

        public void LogError(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        // Creating private method for not repeating this code above twice (DRY: Don't Repeat Yourself)
        private void Log(string message, string messageType)
        {
            //StreamWriter uses FileResource which is not managed by CLR which means we need to dispose that resource once we're done
            //Hence we're enclosing this inside using statement which calls Dispose method behind the scenes automatically
            //There's an exception handling mechanism inside this using that you're not gonna see is implemented by the compiler
            //So if something goes wrong or an exception is thrown, the compiler will make sure to close the file handle by calling the Dispose method
            using (var streamWriter = new StreamWriter(_path, true))
            {
                streamWriter.WriteLine(messageType + ": " + message);
                //streamWriter.Dispose(); //This method is used for freeing external resources that are not managed by CLR
            }
        }
    }
}