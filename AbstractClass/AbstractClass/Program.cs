using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            NewFocus focus = new NewFocus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());
            
            NewCivic civic = new NewCivic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());



        }
    }
}
