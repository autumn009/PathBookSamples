string[] names = { "a", "b", "c" };
Console.WriteLine(Path.Combine(names));
Console.WriteLine(String.Join(Path.DirectorySeparatorChar, names));
