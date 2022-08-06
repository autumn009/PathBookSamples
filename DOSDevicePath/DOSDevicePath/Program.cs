Directory.CreateDirectory(@"c:\Sample");
File.WriteAllText(@"c:\Sample\mytext.txt", "Hello!");

string[] filenames = {
            @"c:\Sample\mytext.txt",
            @"\\127.0.0.1\c$\Sample\mytext.txt",
            @"\\LOCALHOST\c$\Sample\mytext.txt",
            @"\\.\c:\Sample\mytext.txt",
            @"\\?\c:\Sample\mytext.txt",
            @"\\.\UNC\LOCALHOST\c$\Sample\mytext.txt",
            @"\\127.0.0.1\c$\Sample\mytext.txt" };

foreach (var filename in filenames)
{
    FileInfo fi = new FileInfo(filename);
    Console.WriteLine($"FileName: {fi.Name} {fi.Length}bytes FullName: {fi.FullName}");
}
