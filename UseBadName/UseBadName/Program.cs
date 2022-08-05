File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(),"CON"),"Hello!");
Console.WriteLine(File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "CON")));
