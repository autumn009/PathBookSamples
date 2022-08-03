﻿string[] names =
{
    "CON", "PRN", "AUX", "NUL", "COM1", "COM2", "COM3", "COM4", 
    "COM5", "COM6", "COM7", "COM8", "COM9", "LPT1", "LPT2", 
    "LPT3", "LPT4", "LPT5", "LPT6", "LPT7", "LPT8", "LPT9"
};

foreach (var filename in names)
{
    try
    {
        File.WriteAllText(filename, "SAMPLE");
        Console.WriteLine($"{filename} OK");
    }
    catch (IOException e)
    {
        Console.WriteLine($"{filename} BAD");
    }
}
