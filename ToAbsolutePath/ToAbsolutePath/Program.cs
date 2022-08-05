Directory.SetCurrentDirectory(@"c:\Sample");
string[] paths = {
    @"Loid\codename.txt",
    @"c:\Sample\Loid\codename.txt",
    @"..\sample\Loid\codename.txt",
    @"Yor\..\Loid\codename.txt",
    @"c:\Sample\.\Anya\..\Yor\..\.\Loid\codename.txt"
};
foreach (var path in paths)
{
    Console.WriteLine($"from {path}");
    var a = Path.GetFullPath(path);
    Console.WriteLine($"converted {a}");
}