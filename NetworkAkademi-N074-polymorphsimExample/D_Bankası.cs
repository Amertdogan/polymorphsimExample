using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N074_polymorphsimExample
{
    public class D_Bankası:Banka
    {
        public override void IndirimOranınaGöreIndirimYap()
        {
            //Bu banka 0.05 indirim yapacak bu nedenle virtual metotu override ettik.
            AlisVerisTutari -= AlisVerisTutari * 0.05m;
            Console.WriteLine("%5 indirim uygulandı. ");
            Console.WriteLine("Ödenecek tutar " + AlisVerisTutari);

        }
    }
}
