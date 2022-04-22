using Bank.Commands;
using Bank.Models;
using System.Collections.Generic;
using System.Windows.Input;

namespace Bank.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            bankk = new Bankk();
            KontoList = bankk.konta;
            DodajProcenty = new DodajProcentCommand(this);
            Wplata = new WplacCommand(this);
            Wyplata = new WyplacCommand(this);
        }
        public Bankk bankk { get; set; }
        public List<Konto> KontoList { get; set; }
        private Konto selectedKonto;
        public Konto SelectedKonto
        {
            get { return selectedKonto; }
            set 
            {
                selectedKonto = value; 
                OnPropertyChanged();
                OnPropertyChanged(nameof(SaldoKonta));
            }
        }
        public string SaldoKonta
        {
            get { return SelectedKonto.saldoKonta.ToString("n2"); }
            set
            {
                SelectedKonto.saldoKonta = float.Parse(value);
                OnPropertyChanged();
            }
        }
        public void SaldoKontaChanged()
        {
            OnPropertyChanged(nameof(SaldoKonta));
        }

        public ICommand DodajProcenty { get; }
        public ICommand Wplata { get; }
        public ICommand Wyplata { get; }
    }
}
