using System;

namespace ArenaSavasOyunu
{
    class Karakter
    {
        public string Ad { get; set; }
        private int can;
        private int guc;
        private int mana;

        public static int SaldiriSayisi = 0;

        public int Can
        {
            get { return can; }
            set { can = value < 0 ? 0 : value; }
        }

        public int Guc
        {
            get { return guc; }
            set { guc = value; }
        }

        public int Mana
        {
            get { return mana; }
            set { mana = value; }
        }

        public Karakter(string ad, int can, int guc, int mana)
        {
            Ad = ad;
            Can = can;
            Guc = guc;
            Mana = mana;
        }

        public virtual void Saldir(Karakter hedef)
        {
            hedef.Can -= Guc;
            SaldiriSayisi++;
            Console.WriteLine($"{Ad}, {hedef.Ad}'a {Guc} hasar verdi!");
        }

        public virtual void OzelYetenek(Karakter hedef)
        {
            if (Mana >= 100)
            {
                int hasar = Guc + 20;
                hedef.Can -= hasar;
                Mana -= 100;
                Console.WriteLine($"{Ad}, özel yetenek kullandı ve {hedef.Ad}'a {hasar} hasar verdi!");
            }
            else
            {
                Console.WriteLine($"{Ad}, yeterli mana yok! Mana yenilemeniz gerekiyor.");
            }
        }

        public void ManaYenile()
        {
            Mana += 100;
            Console.WriteLine($"{Ad}, 100 mana yeniledi.");
        }
    }
}
