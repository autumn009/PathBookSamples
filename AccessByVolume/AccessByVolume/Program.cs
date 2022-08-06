using System.Management;

Directory.CreateDirectory(@"c:\Sample");
File.WriteAllText(@"c:\Sample\mytext.txt", "Hello!");

var path = sub() + @"Sample\mytext.txt";
Console.WriteLine($"read from {path}");
Console.WriteLine(File.ReadAllText(path));

string? sub()
{
    var ms = new ManagementObjectSearcher("Select * from Win32_Volume");
    foreach (ManagementObject mo in ms.Get())
    {
        var guid = mo["DeviceID"].ToString();
        if (mo["DriveLetter"].ToString() == "C:") return guid;
    }
    throw new Exception("Not Found");
}
