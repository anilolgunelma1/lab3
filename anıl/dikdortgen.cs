using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class dikdortgen:sekil
    {
        int uzunkenar;
        int kısakenar;
        public dikdortgen(int x,int y) : base(x,y)
        {
            base.X = kısakenar;
            base.Y = uzunkenar;

        }
        public override double AlanHesapla()
        {
            return uzunkenar * kısakenar;
            
        }
        public override double CevreHesapla()
        {
            return (kısakenar + uzunkenar) * 2;
        }
    }
}
