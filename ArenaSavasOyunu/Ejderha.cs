using System;

namespace ArenaSavasOyunu
{
    class Ejderha : Dusman
    {
        public Ejderha() : base("Ejderha", 170, 40, 100) { }

        public override void OzelYetenek(Karakter hedef)
        {
            if (Mana >= 100)
            {
                hedef.Can -= Guc + 10;
                Mana -= 100;
                Console.WriteLine($"{Ad}, ejderha aleviyle {hedef.Ad}'a ağır hasar verdi!");
            }
            else
            {
                Console.WriteLine($"{Ad}, yeterli mana yok.");
            }
        }
    }
}
