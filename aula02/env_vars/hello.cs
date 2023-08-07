using System;

class Program
{   
    
    static void Main()
    {
        string  envVarName = "AMBIENTE_AUDACES"; 
        string  envVarValue = Environment.GetEnvironmentVariable(envVarName);
        Console.WriteLine($"Hello, {envVarValue}!");
    }
}