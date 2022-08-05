foreach (var item in Directory.EnumerateFileSystemEntries(@"c:\Sample", "*.*", SearchOption.AllDirectories))
{
    Console.WriteLine(item);
}
