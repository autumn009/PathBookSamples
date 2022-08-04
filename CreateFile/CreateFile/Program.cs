// 必ず新規に作る
using (var s1 = new FileStream("sample.bin", FileMode.CreateNew))
{
    s1.WriteByte(0x55);
}
dump();
// 追加書き込み
using (var s1 = new FileStream("sample.bin", FileMode.Append))
{
    s1.WriteByte(0xAA);
}
dump();
// 上書き書き込み
using (var s1 = new FileStream("sample.bin", FileMode.Create))
{
    s1.WriteByte(0x5A);
}
dump();

void dump()
{
    var bytes = File.ReadAllBytes("sample.bin");
    Console.WriteLine(String.Join(',', bytes.Select(c=>c.ToString("X2"))));
}
