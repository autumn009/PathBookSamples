Directory.CreateDirectory("mydir");
File.WriteAllText("myfile.txt","Hello!");

sub("mydir");
sub("myfile.txt");
sub("nofile.txt");

void sub(string path)
{
    Console.WriteLine($"about {path}");
    Console.WriteLine($"Directory.Exists={Directory.Exists(path)}");
    Console.WriteLine($"File.Exists={File.Exists(path)}");
}

