using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    
        abstract class sekil
        {
            private int x;
            private int y;
            public string name;
            public sekil(int x, int y)
            {
                X = x;
                Y = y;
            }

            public int X { get { return x; } set { x = value; } }
            public int Y { get { return y; } set { y = value; } }


            public abstract double AlanHesapla();
            public abstract double CevreHesapla();
           // public abstract double GetName();

        }
    }


