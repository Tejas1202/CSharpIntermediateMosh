﻿namespace CSharpIntermediateConsoleApp.Interfaces.Extensibility
{
    public interface ILogger
    {
        void LogError(string message);
        void LogInfo(string message);
    }
}