Directory.SetCurrentDirectory(@"m:\");
Directory.CreateDirectory("Sample1");
Directory.SetCurrentDirectory("Sample1");
File.WriteAllText("mytext.txt","Hello!");
Console.WriteLine($"Current Directory={Directory.GetCurrentDirectory()}");
Console.WriteLine(File.ReadAllText("m:mytext.txt"));
Directory.SetCurrentDirectory(@"n:\");
Console.WriteLine($"Current Directory={Directory.GetCurrentDirectory()}");
try
{
    Console.WriteLine(File.ReadAllText("m:mytext.txt"));
}
catch (FileNotFoundException e)
{
    Console.WriteLine(e.Message);
}