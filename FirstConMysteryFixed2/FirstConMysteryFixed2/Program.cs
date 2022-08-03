using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Text;

System.Text.Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
File.WriteAllText("DON", "ドーン");
File.WriteAllText("CON", "コーン", System.Text.Encoding.GetEncoding(GetACP()));

[DllImport("kernel32.dll")][ResourceExposure(ResourceScope.None)] static extern int GetACP();
