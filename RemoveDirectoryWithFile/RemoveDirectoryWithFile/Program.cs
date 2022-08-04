Directory.CreateDirectory("Sample");
File.WriteAllText(@"Sample\myFile.txt","Hello!");
Directory.Delete("Sample");
