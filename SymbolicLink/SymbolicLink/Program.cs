Directory.CreateDirectory(@"c:\Sample\real");
Directory.CreateSymbolicLink(@"c:\Sample\refer", @"c:\Sample\real");
File.WriteAllText(@"c:\Sample\real\mytext.txt","Hello!");
Console.WriteLine(File.ReadAllText(@"c:\Sample\refer\mytext.txt"));
