using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class dikucgen :sekil
    {
        private double hipo;
        int tabanalanı;
        int yükseklik;
        public dikucgen(int x,int y) : base(x,y)
        {
            hipo = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            base.X = tabanalanı;
            base.Y = yükseklik;
        }

        public override double AlanHesapla()
        {
            return (tabanalanı * yükseklik) / 2;
        }
        public override double CevreHesapla()
        {
            return hipo + tabanalanı + yükseklik;
        }

    }
}
