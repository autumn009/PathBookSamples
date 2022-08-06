var tempPath = Path.GetTempPath();
var tempFileName = Path.GetTempFileName();
var tempRandomoFileName = Path.GetRandomFileName();
Console.WriteLine($"tempPath={tempPath}");
Console.WriteLine($"tempFileName={tempFileName}");
Console.WriteLine($"tempFileName exists={File.Exists(tempFileName)}");
Console.WriteLine($"tempRandomoFileName={tempRandomoFileName}");
File.Delete(tempFileName);
