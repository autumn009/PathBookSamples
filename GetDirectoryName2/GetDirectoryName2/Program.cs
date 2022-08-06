var path = @"c:\a\b\c\d\e.txt";
var s = path;
for (; ; )
{
    var name = Path.GetFileName(s);
    if (name == "")
    {
        Console.WriteLine($"[{s}]");
        break;
    }
    Console.WriteLine($"[{name}]");
    s = Path.GetDirectoryName(s);
}
