using Bank.Commands;
using Bank.Models;
using System.Collections.Generic;
using System.Windows.Input;

namespace Bank.ViewModels
{
    public class PrzelewyViewModel : ViewModelBase
    {
        public PrzelewyViewModel(Bankk bankk)
        {
            this.bankk = bankk;
            KontoList = bankk.konta;
            UpdateView = MainWindowModel.UpdateView;
            WykonajPrzelew = new WykonajPrzelewCommand(this);
        }

        public Bankk bankk { get; set; }
        public List<Konto> KontoList { get; set; }

        private Konto selectedKontoZ;
        public Konto SelectedKontoZ
        {
            get { return selectedKontoZ; }
            set
            {
                selectedKontoZ = value;
                OnPropertyChanged();
            }
        }
        public Konto SelectedKontoZItem
        {
            get { return KontoList[0]; }
            set
            {
                selectedKontoZ = value;
                OnPropertyChanged();
            }
        }
        private Konto selectedKontoDo;
        public Konto SelectedKontoDo
        {
            get { return selectedKontoDo; }
            set
            {
                selectedKontoDo = value;
                OnPropertyChanged();
            }
        }
        public Konto SelectedKontoDoItem
        {
            get { return KontoList[1]; }
            set
            {
                selectedKontoDo = value;
                OnPropertyChanged();
            }
        }

        private string kwota;
        public string Kwota
        {
            get { return kwota; }
            set
            {
                kwota = value;
                OnPropertyChanged();
            }
        }

        public ICommand UpdateView { get; set; }
        public ICommand WykonajPrzelew { get; set; }

    }
}
