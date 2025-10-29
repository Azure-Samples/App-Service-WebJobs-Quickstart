// Program.cs
// .NET Console App to print current system date and time
// To compile and run:
//   dotnet run
// To publish as an EXE file for Windows:
//   dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true
// The output run.exe will be in bin/Release/net*/win-x64/publish/
//
// To publish for Linux:
//   dotnet publish -c Release -r linux-x64 --self-contained true /p:PublishSingleFile=true
// The output run executable will be in bin/Release/net8.0/linux-x64/publish/.
// You need to package it with a Bash script to run it with "./run".
// To package in a ZIP file for Linux deployment:
//  zip -j dotnet-lin.zip run.sh bin/Release/net8.0/linux-x64/publish/*

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Current system date and time:");
        Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
    }
}
