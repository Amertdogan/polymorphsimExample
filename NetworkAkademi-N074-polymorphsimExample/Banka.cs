using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAkademi_N074_polymorphsimExample
{
    public class Banka
    {
        #region FİELD AND PROPERTY
        public string BankaAdi { get; set; }

        private decimal _alisVerisTutari=0;

        public decimal AlisVerisTutari { get; set; }

        #endregion

        #region METOTLAR

        public  void BilgileriAl()
        {
            Console.WriteLine(BankaAdi+" bankasına hoşgeldiniz");
            Console.WriteLine("Aliş veriş tutari: ");
            _alisVerisTutari = Convert.ToDecimal(Console.ReadLine());
            if (_alisVerisTutari>0)
            {
                AlisVerisTutari = _alisVerisTutari;
            }
            else
            {
                throw new Exception("Tutarı sıfırdan büyük olmalıdır. ");
            }
        }

        public virtual void IndirimOranınaGöreIndirimYap()
        {
            AlisVerisTutari -= AlisVerisTutari * 0.20m;
            Console.WriteLine("%20 indirim uygulandı. ");
            Console.WriteLine("Ödenecek tutar "+AlisVerisTutari);
        }

        #endregion

    }
}
