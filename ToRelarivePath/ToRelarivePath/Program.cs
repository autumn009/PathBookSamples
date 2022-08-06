var relavePath = Path.GetRelativePath(@"c:\dir1", @"c:\dir1\dir2\myFile.txt");
Console.WriteLine(relavePath);
var relavePath2 = Path.GetRelativePath(@"c:\dir1", @"c:\dir1\..\dir1\dir2\.\myFile.txt");
Console.WriteLine(relavePath2);
