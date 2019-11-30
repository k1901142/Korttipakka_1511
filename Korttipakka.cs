using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Korttipakka_1511
{
    class Korttipakka
    {
        private List<Kortti> pakka = new List<Kortti>();

        public Korttipakka()
        {
            Alusta();
        }

        public List<Kortti> Jaa(int n) //n = korttien määrä
        {
            // otetaan kortteja pakan päältä
            List<Kortti> kasi = pakka.GetRange(0, n);

            pakka.RemoveRange(0, n);

            return kasi;
        }

        public override string ToString()
        {
            string s = "";

            foreach (var kortti in pakka)
            {
                s += kortti.ToString() + '\n';
            }

            return s;
        }

        public void Sekoita()
        {

            Random gen = new Random();

            int n = pakka.Count;

            while (n> 1)
            {
                n--;
                int k = gen.Next(n+1);
                Kortti value = pakka[k];
                pakka[k] = pakka[n];
                pakka[n] = value;
            }

        }

        public void Jarjesta()
        {
            pakka.Sort();
        }

        public void Alusta()
        {
            string[] maat = { "Hertta", "Ruutu", "Risti", "Pata" };

            for (int i = 0; i < maat.Length; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Kortti k = new Kortti(maat[i], j);
                    pakka.Add(k);
                }
            }

        }

    }
}
