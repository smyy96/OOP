using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Otomobil
    {
        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public virtual Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }

        public abstract Marka HangiMarkaninAraci();
    }
}
