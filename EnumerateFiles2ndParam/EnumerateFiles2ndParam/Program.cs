Directory.CreateDirectory(@"c:\Sample");
Directory.SetCurrentDirectory(@"c:\Sample");
File.WriteAllText("t", "sample");
File.WriteAllText("t.t", "sample");
File.WriteAllText("t.t.t", "sample");
File.WriteAllText("t.t.t.t", "sample");

sub("*");
sub("*.*");
sub("*.*.*");

void sub(string searchPattern)
{
    Console.WriteLine($"searchPattern={searchPattern}");
    foreach (var item in Directory.EnumerateFiles(".", searchPattern, SearchOption.AllDirectories))
    {
        Console.WriteLine(item);
    }
}
