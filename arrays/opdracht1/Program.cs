using System;

namespace opdracht1 {
class Program
{
    static void Main(string[] args)
    {

        string[] name = { "Peter ", "is ", "de ", "broer ", "van ", "Hans " };

foreach (string zin in name)
{
    Console.Write(zin);
}

string str = Environment.NewLine;

Console.WriteLine(str);

Console.Write(name[5]);
Console.Write(name[1]);
Console.Write(name[2]);
Console.Write(name[3]);
Console.Write(name[4]);
Console.Write(name[0]);

}
}
}