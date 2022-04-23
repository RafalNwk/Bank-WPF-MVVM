using Bank.Commands;
using Bank.Models;
using System.Collections.Generic;
using System.Windows.Input;

namespace Bank.ViewModels
{
    public class NoweKontoViewModel : ViewModelBase
    {
        public NoweKontoViewModel(Bankk bankk)
        {
            this.bankk = bankk;
            rodzajKontaList = bankk.rodzajKonta;
            UpdateView = MainWindowModel.UpdateView;
            DodajKonto = new DodajKontoCommand(this);
        }
        public Bankk bankk { get; set; }
        public List<RodzajKonta> rodzajKontaList { get; set; }
        private RodzajKonta selectedRodzajKonta;
        public RodzajKonta SelectedRodzajKonta
        {
            get { return selectedRodzajKonta; }
            set
            {
                selectedRodzajKonta = value;
                OnPropertyChanged();
            }
        }
        public RodzajKonta SelectedRodzajItem
        {
            get { return rodzajKontaList[0]; }
            set
            {
                selectedRodzajKonta = value;
                OnPropertyChanged();
            }
        }

        private string nazwa;
        public string Nazwa
        {
            get { return nazwa; }
            set
            {
                nazwa = value;
                OnPropertyChanged();
            }
        }
        public ICommand UpdateView { get; set; }
        public ICommand DodajKonto { get; }

    }
}
