Directory.SetCurrentDirectory(@"c:\Sample");
sub(".");
sub(@"c:\Sample");
Directory.SetCurrentDirectory(@"c:\");
sub(@"Sample");

void sub(string baseDirectoery)
{
	Console.WriteLine($"base is {baseDirectoery}");
	Console.WriteLine(String.Join(',', Directory.EnumerateFiles(baseDirectoery, "*.txt", SearchOption.AllDirectories)));
}
