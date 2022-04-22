using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitki tohumluBitki = new TohumluBitki();
            tohumluBitki.tohumlacogalma();

            Kuslar marti = new Kuslar();
            marti.Ucmak();
        }
    }
}
