var path1 = @"dir\myfile.txt";
var path2 = @"dir\myfile";
Console.WriteLine($"add ext '.txt' to {path2}={Path.ChangeExtension(path2, "txt")}");
Console.WriteLine($"remove ext from {path1}={Path.GetFileNameWithoutExtension(path1)}");
Console.WriteLine($"remove ext from {path1}={Path.ChangeExtension(path1, null)}");
Console.WriteLine($"remove ext from {path1}={Path.ChangeExtension(path1, "")}");
Console.WriteLine($"change ext to '.bak' {path1}={Path.ChangeExtension(path1, "bak")}");




