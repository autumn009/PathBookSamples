// 開始時のカレントディレクトリ
var oldCurrentDirectory = Directory.GetCurrentDirectory();
// ディレクトリ作成
var directoryInfo = Directory.CreateDirectory("Sample");
// カレントディレクトリ変更
Directory.SetCurrentDirectory("Sample");
// myText.txtを作成
File.WriteAllText("myText.txt","Hello!");
// カレントディレクトリを出力
Console.WriteLine($"Current Directory={Directory.GetCurrentDirectory()}");
// カレントディレクトリからmyText.txtを主強く
Console.WriteLine(File.ReadAllText("myText.txt"));
// カレントディレクトリを戻す
Directory.SetCurrentDirectory(oldCurrentDirectory);
// 作ったディレクトリの削除
Directory.Delete(directoryInfo.FullName,true);
// カレントディレクトリを出力
Console.WriteLine($"Current Directory={Directory.GetCurrentDirectory()}");
