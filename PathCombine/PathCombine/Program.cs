var d = @"c:";
var a = "a";
var b = "b";
var c = "c.txt";

// bad case
Console.WriteLine(d + "\\" + a + "\\" + b + "\\" + c);
// better case
Console.WriteLine(d + Path.DirectorySeparatorChar + a + Path.DirectorySeparatorChar + b + Path.DirectorySeparatorChar + c);
// more better case
Console.WriteLine(Path.Combine(d, a, b, c));
