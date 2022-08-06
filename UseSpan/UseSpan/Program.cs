var path = @"c:\Sample\myfile.txt";

Console.WriteLine("by string");
string r = Path.GetFileName(path);
Console.WriteLine(r);

Console.WriteLine("by ReadOnlySpan<char>");
ReadOnlySpan<char> r2 = Path.GetFileName(path.AsSpan());
foreach (var item in r2) Console.Write(item);
Console.WriteLine();
