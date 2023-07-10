// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");
Console.WriteLine("Bem-vinda a Tabuada");

string dado = string.Empty;
int numero = ReadInt("Qual número deseja sua tabuada?");

var sw = new Stopwatch();
sw.Start();

for (int i = 1; i < 20; i++)
{
    Console.WriteLine($"{numero} x {i} = {numero * i}");
}

sw.Stop();
Console.WriteLine("Tempo gasto : " + sw.ElapsedMilliseconds.ToString() + " milisegundos");


static int ReadInt(string prompt)
{
    string text;
    do
    {
        Console.Write(prompt);
        text = Console.ReadLine();
    } while (!text.Where(c => char.IsNumber(c)).Any());

    return int.Parse(new string(text.Where(c => char.IsNumber(c)).ToArray()));
}