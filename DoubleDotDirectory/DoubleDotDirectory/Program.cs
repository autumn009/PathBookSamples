Directory.SetCurrentDirectory(@"c:\Sample");
var di = new DirectoryInfo(".");

Console.WriteLine("The Directory Contains:");
foreach (var item in di.EnumerateDirectories())
{
    Console.WriteLine(item.Name);
}
Console.WriteLine("That's all!");
sub(".");
sub("..");

void sub(string name) => Console.WriteLine($"{name} exists={Directory.Exists(name)}");
