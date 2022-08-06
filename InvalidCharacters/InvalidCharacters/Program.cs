Console.WriteLine("InvalidPathChars");
Console.WriteLine(String.Join(',', Path.GetInvalidPathChars().Select(ch => ((int)ch).ToString("X04"))));
Console.WriteLine("InvalidFileNameChars");
Console.WriteLine(String.Join(',', Path.GetInvalidFileNameChars().Select(ch => ((int)ch).ToString("X04"))));
