using System;

namespace Klasy
{
    class Program
    {
        string napis;
    public void WczytajNapis()
    {
        System.Console.WriteLine("Wprowadź napis.");
        napis = System.Console.ReadLine();
    }
    public void Napisz()
    {
        System.Console.Write("Napisałeś -> ");
        System.Console.WriteLine(napis);
    }
}
class KlasaGlowna
{
    static void Main()
    {
        Program obiekt = new Program();//new tworzy obiekt na podstawie zdefiniowanej klasy
        obiekt.WczytajNapis();
        obiekt.Napisz();
       // System.Console.ReadLine();
    }// zmiana na githuba 10.03
    }
}
