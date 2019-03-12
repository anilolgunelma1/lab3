using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList KingofList = new ArrayList();
            dikucgen ucgen = new dikucgen(3, 4);
            dikdortgen dikdortgen = new dikdortgen(4, 5);
            Daire daire = new Daire(5,2,5.5);

            KingofList.Add(ucgen);
            KingofList.Add(dikdortgen);
            KingofList.Add(daire);
            
          
            KingofList.Add("Dolu");
            KingofList.Add(11.2);



            Console.WriteLine("Listede olan elemanlar");
            foreach ( var a in KingofList)
                Console.WriteLine(a);
            Console.WriteLine("Hesaplar");
            Yazdir(KingofList);
            Temizle(KingofList);
            Console.ReadKey();


        }
        static void Yazdir(ArrayList dizilist)
        {
            foreach( object obj in dizilist)
            {
                if(obj is sekil )
                {
                    sekil cok_sekil;
                    cok_sekil = obj as sekil;
                    Console.WriteLine(cok_sekil.AlanHesapla()+cok_sekil.CevreHesapla());

                }
            }
        }
        static void Temizle(ArrayList dizilist)
        {
            for (int i = 0; i < dizilist.Count; i++)
            {
                if (!(dizilist is sekil ))
                {
                    dizilist.RemoveAt(i);
                    i--;

                }
            }
        }
    }
}
