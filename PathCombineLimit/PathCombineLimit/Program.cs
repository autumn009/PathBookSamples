var r = Path.Combine("a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z");
Console.WriteLine(r);
var array = Enumerable.Range(0, 26).Select(c => ((char)(c + 'a')).ToString()).ToArray();
var r2 = Path.Combine(array);
Console.WriteLine(r2);
