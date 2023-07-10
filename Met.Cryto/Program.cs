using System.IO;
using System.Text;

Console.WriteLine("Hello, World!");
var path = @"C:\Data\";
var arquivo = "naoleia.txt";
var arquivoCrypto = "querover.txt";
var arquivoDescrypto = "agoraver.txt";

var texto = File.ReadAllText(string.Concat(path, arquivo));

var sb = new StringBuilder();

for (int i = 0; i < texto.Length; i++)
{
    sb.Append((char)texto[i] + 10);
}

File.WriteAllText(string.Concat(path, arquivoCrypto), sb.ToString());

var textoCrypto = File.ReadAllText(string.Concat(path, arquivoCrypto));

var sbCrypto = new StringBuilder();
for (int i = 0; i < textoCrypto.Length; i++)
{
    sbCrypto.Append((char)textoCrypto[i] - 10);
}

File.WriteAllText(string.Concat(path, arquivoDescrypto), sbCrypto.ToString());


Console.ReadKey();