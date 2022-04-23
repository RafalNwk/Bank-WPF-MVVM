using Bank.Commands;
using Bank.Models;
using System.Collections.Generic;
using System.Windows.Input;

namespace Bank.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public HomeViewModel(Bankk bankk)
        {
            this.bankk = bankk;
            KontoList = bankk.konta;
            DodajProcenty = new DodajProcentCommand(this);
            Wplata = new WplacCommand(this);
            Wyplata = new WyplacCommand(this);
            UpdateView = MainWindowModel.UpdateView;
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
        public Konto SelectedKontoItem
        {
            get { return KontoList[0]; }
            set
            {
                selectedKonto = value;
                OnPropertyChanged();
            }
        }
        public string SaldoKonta
        {
            get
            {
                if (selectedKonto == null) return "";
                return SelectedKonto.saldoKonta.ToString("n2");
            }
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
        public ICommand UpdateView { get; set; }

        public ICommand DodajProcenty { get; }
        public ICommand Wplata { get; }
        public ICommand Wyplata { get; }
    }
}
