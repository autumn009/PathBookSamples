Directory.SetCurrentDirectory(@"c:\Sample");

var di = new DirectoryInfo(".");

foreach (FileInfo item in di.EnumerateFiles("*.*", SearchOption.AllDirectories))
{
    Console.WriteLine($"Name={item.Name}");
    Console.WriteLine($"FullName={item.FullName}");
}

foreach (DirectoryInfo item in di.EnumerateDirectories("*.*", SearchOption.AllDirectories))
{
    Console.WriteLine($"Name={item.Name}");
    Console.WriteLine($"FullName={item.FullName}");
}


