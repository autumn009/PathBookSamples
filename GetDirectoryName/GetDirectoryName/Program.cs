var path = @"c:\a\b\c\d\e.txt";

Console.WriteLine($"Path={path}");
Console.WriteLine($"FileName={Path.GetFileName(path)}");
Console.WriteLine($"DirectoryName={Path.GetDirectoryName(path)}");
