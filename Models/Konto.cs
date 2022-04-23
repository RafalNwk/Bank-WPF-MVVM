namespace Bank.Models
{
    public class Konto
    {
        public static int ids;
        public int id { get; }
        public string nazwa { get; set; }
        public float saldoKonta { get; set; }
        public RodzajKonta WybranyRodzajKonta { get; set; }
        public Konto(string nazwa, RodzajKonta rodzaj)
        {
            ids++;
            this.nazwa = nazwa;
            this.id = ids;
            this.saldoKonta = 0;
            this.WybranyRodzajKonta = rodzaj;
        }
    }
}
