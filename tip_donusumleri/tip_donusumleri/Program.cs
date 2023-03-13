using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tip_donusumleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İmplicit Conversion
            byte a = 5;
            sbyte b = 30;
            short c = 10;
            int d = a + b + c;
            Console.WriteLine(d);

            long h = d;
            Console.WriteLine(h);

            float i = h;
            Console.WriteLine(i);

            string e = "gokhan";
            char f = 's';
            object o = e + f + d;
            Console.WriteLine(o);
            //Explicit Conversion

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine(y);

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine(t);


            //ToString
            int xx = 7;
            string yy = xx.ToString();
            Console.WriteLine(yy);

            string zz = 12.5f.ToString();
            Console.WriteLine(zz);

            //System Convert
            string s1 = "12", s2 = "33";
            int sayi1, sayi2;
            int toplam;
            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }
    }
}
