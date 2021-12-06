using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N074_polymorphsimExample
{
    class Program
    {
        static void Main(string[] args)
        {
            //polymorphism
            Console.WriteLine("Bir banka seciniz: A/D");
            ConsoleKeyInfo secim;
            secim = Console.ReadKey();


            if (secim.Key==ConsoleKey.A)
            {
                A_Bankası bankam = new A_Bankası();
                bankam.BilgileriAl();
                bankam.IndirimOranınaGöreIndirimYap();
            }
            else if (secim.Key==ConsoleKey.D)
            {
                D_Bankası bankam1 = new D_Bankası();
                bankam1.BilgileriAl();
                bankam1.IndirimOranınaGöreIndirimYap();
            }


            Console.ReadKey();
        }
    }
}
