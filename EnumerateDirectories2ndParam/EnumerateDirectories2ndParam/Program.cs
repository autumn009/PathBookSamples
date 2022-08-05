Directory.CreateDirectory(@"c:\Sample\a\b.b\c.c.c\d.d.d.d\e.e.e.e.e");
Directory.SetCurrentDirectory(@"c:\Sample");

sub("*");
sub("*.*");
sub("*.*.*");

void sub(string searchPattern)
{
    Console.WriteLine($"searchPattern={searchPattern}");
    foreach (var item in Directory.EnumerateDirectories(".", searchPattern, SearchOption.AllDirectories))
    {
        Console.WriteLine(item);
    }
}
