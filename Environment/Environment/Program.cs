// 環境変数に書き込む
Environment.SetEnvironmentVariable("Sample",@"c:\Sample");
// 環境変数から読み込む
Console.WriteLine(Environment.GetEnvironmentVariable("Sample") ?? "(null)");
Console.WriteLine(Environment.GetEnvironmentVariable("Sample", EnvironmentVariableTarget.User)??"(null)");
Console.WriteLine(Environment.GetEnvironmentVariable("Sample", EnvironmentVariableTarget.Machine) ?? "(null)");
