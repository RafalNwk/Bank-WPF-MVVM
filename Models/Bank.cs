using System.Collections.Generic;
using System.Linq;

namespace Bank.Models
{
    public class Bankk
    {
        public List<Konto> konta = new List<Konto>();
        public List<RodzajKonta> rodzajKonta = new List<RodzajKonta>();
        public Bankk()
        {
            rodzajKonta.Add(new RodzajKonta("Standard", 3.0f));
            rodzajKonta.Add(new RodzajKonta("Premium", 5.0f));
            rodzajKonta.Add(new RodzajKonta("Platinium", 8.0f));
            NoweKonto("Konto Pierwsze", 1000, rodzajKonta[0]);
            NoweKonto("Konto Oszczędnościowe", 1500, rodzajKonta[1]);
        }
        public void NoweKonto(string nazwa, float stanKonta, RodzajKonta rodzaj)
        {
            konta.Add(new Konto(nazwa, stanKonta, rodzaj));
            int ID = konta.Last().id;
            //MessageBox.Show($"Stworzono konto {nazwa}, ID: {ID} Stan konta: {stanKonta}  Rodzaj konta: {rodzaj.Nazwa}");
        }
        public void Wplata(int id, float pieniadz)
        {
            konta.Find(x => x.id == id).saldoKonta += pieniadz;
        }
        public void Wyplata(int id, float pieniadz)
        {
            konta.Find(x => x.id == id).saldoKonta -= pieniadz;
        }
        public void DoliczOprocentowanie(int id)
        {
            konta.Find(x => x.id == id).saldoKonta += (konta.Find(x => x.id == id).saldoKonta) * (konta.Find(x => x.id == id).WybranyRodzajKonta.Oprocentowanie/100);
        }
    }

}
