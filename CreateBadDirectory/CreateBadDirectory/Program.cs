try
{
    Directory.CreateDirectory("CON");
}
catch(IOException e)
{
    Console.WriteLine(e.Message);
}