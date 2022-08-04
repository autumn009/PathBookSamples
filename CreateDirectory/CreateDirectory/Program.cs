DumpDirectory();
Console.WriteLine("CreateDirectory!");
Directory.CreateDirectory("Sample");
DumpDirectory();
Console.WriteLine("CreateDirectory!");
Directory.CreateDirectory("Sample");
DumpDirectory();

void DumpDirectory()
{
	foreach (var item in Directory.EnumerateDirectories("."))
	{
		Console.Write($"[{item.Replace(".\\","")}]");
	}
	Console.WriteLine();
	Console.WriteLine($"found {Directory.EnumerateDirectories(".").Count()} directories");
}

