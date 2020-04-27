using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egitim_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Merhaba Dünya");
            Console.WriteLine(Günler.Pazartesi);
            Console.WriteLine((int)Günler.Sali);
            Console.ReadKey();
        }
        enum Günler
        {
            Pazartesi,Sali,Carsamba,Persembe,Cuma,Cumartesi,Pazar
        }
    }
}
