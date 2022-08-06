var unc = @"\\akane4\Sample";
var di = Directory.CreateDirectory(Path.Combine(unc,"MyDir"));
Directory.SetCurrentDirectory(di.FullName);
Console.WriteLine($"CurrentDirectory={Directory.GetCurrentDirectory()}");
File.WriteAllText("hello.txt","Hello");
File.WriteAllText("world.txt", "World");
foreach (var item in di.EnumerateFiles())
{
    Console.WriteLine(item.FullName);
}
