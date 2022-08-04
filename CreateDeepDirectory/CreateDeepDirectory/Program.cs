Directory.CreateDirectory(@"a\b\c\d");
File.WriteAllText(@"a\b\c\d\e.txt","From Deep Directory");
Console.WriteLine(File.ReadAllText(@"a\b\c\d\e.txt"));
