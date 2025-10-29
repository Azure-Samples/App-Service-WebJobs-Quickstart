// F# script to print current system date and time
// To run: dotnet fsi run.fsx

printfn "Current system date and time:"
printfn "%s" (System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
