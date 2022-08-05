Console.WriteLine("by GetFiles");
DateTime start = DateTime.Now;
var fles = Directory.GetFiles(@"n:\tools","*.*", SearchOption.AllDirectories);
Console.WriteLine(DateTime.Now-start);

Console.WriteLine("by EnumerateFiles");
DateTime start2 = DateTime.Now;
var fles2 = Directory.EnumerateFiles(@"n:\tools", "*.*", SearchOption.AllDirectories);
Console.WriteLine(DateTime.Now - start2);



