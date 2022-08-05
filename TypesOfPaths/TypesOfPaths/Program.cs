Directory.CreateDirectory(@"c:\Sample");
Directory.SetCurrentDirectory(@"c:\Sample");
Directory.CreateDirectory("Loid");
Directory.CreateDirectory("Yor");
Directory.CreateDirectory("Anya");
var oldDir = Directory.GetCurrentDirectory();
Directory.SetCurrentDirectory("Loid");
File.WriteAllText("codename.txt", "Tasogare");
Directory.SetCurrentDirectory(oldDir);
Directory.SetCurrentDirectory("Yor");
File.WriteAllText("codename.txt", "Ibarahime");
Directory.SetCurrentDirectory(oldDir);

sub("Partial Path",@"Loid\codename.txt");
sub("Absolute Path",@"c:\Sample\Loid\codename.txt");
Directory.SetCurrentDirectory("Yor");
sub("Releative Path",@"..\Loid\codename.txt");
Directory.SetCurrentDirectory(oldDir);
sub("Releative Path", @"Yor\..\Loid\codename.txt");
Directory.SetCurrentDirectory("Loid");
sub("Releative Path", Path.GetFullPath(@".\codename.txt"));
Directory.SetCurrentDirectory(oldDir);
sub("Stray Path", @"c:\Sample\.\Anya\..\Yor\..\.\Loid\codename.txt");

void sub(string name, string path)
{
    Console.WriteLine($"{name}, from \"{path}\" CuurentDirectory={Directory.GetCurrentDirectory()}");
    Console.WriteLine(File.ReadAllText(path));
}


