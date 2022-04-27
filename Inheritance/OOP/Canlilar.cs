using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Canlilar
    {
       protected void Beslenme() // protected tanımlama sanadece o sınıf ve katılım alanaların erişimine izin veriyor.
        {
            Console.WriteLine("Canlılar beslenir");
        }

        protected void Solunum()
        {
            Console.WriteLine("Canlılar solunum yapar.");
        }

        protected void Bosaltim()
        {
            Console.WriteLine("Canlılar boşaltım yapar.");
        }

        public virtual void UyaranlaraTepki() // virtual kullanımı
        {
             Console.WriteLine("Canlılar uyaranlara tepki verir.");
        }


    }
}
