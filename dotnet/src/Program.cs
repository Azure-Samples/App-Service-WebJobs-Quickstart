// Program.cs
// .NET Console App to print current system date and time
// To compile and run:
//   dotnet run
// To publish as a single file:
//   dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true
// The output will be in bin/Release/net*/win-x64/publish/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Current system date and time:");
        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
    }
}
