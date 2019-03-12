using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Daire: sekil
    {
        private double r;
        public Daire(int x,int y,double r) : base (x,y)
        {
            base.X = x;
            base.Y = y;
            this.r = r;
        }
        public override double AlanHesapla()
        {
            return Math.PI * this.r * this.r;
        }
        public override double CevreHesapla()
        {
            return 2 * Math.PI * this.r;
        }
    }
}
