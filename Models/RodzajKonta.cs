namespace Bank.Models
{
    public class RodzajKonta
    {
        public string Nazwa { get; }
        public float Oprocentowanie { get; set; }
        public RodzajKonta(string nazwa, float oprocentowanie)
        {
            Nazwa = $"{nazwa} {oprocentowanie}%";
            Oprocentowanie = oprocentowanie;
        }
    }
}
