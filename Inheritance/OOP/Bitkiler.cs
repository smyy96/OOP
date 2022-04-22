using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Bitkiler :Canlilar
    {
        protected void Fotosentez() // protected tanımladık çünkü, sadece kalıtım alan sınıftan erişim sagalabilsin diye
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }
    }

    public class TohumluBitki:Bitkiler
    {
        public TohumluBitki()
        {
            base.Fotosentez(); // protected olarak tanımladıgımız metota erişim saglayabilmek için yapıcı metot tanımlaıp base ile o metota arişim saglayabildik.
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();

        }
        public void tohumlacogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla cogalır.");
        }
    }

    public class TohumsuzBitki:Bitkiler
    {

        public TohumsuzBitki()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();

        }

        public void tohumsuzcogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla cogalır.");
        }
    }

}
