using Bank.ViewModels;

namespace Bank.Commands
{
    public class DodajKontoCommand : CommandBase
    {
        private readonly NoweKontoViewModel noweKontoViewModel;
        public DodajKontoCommand(NoweKontoViewModel noweKontoViewModel)
        {
            this.noweKontoViewModel = noweKontoViewModel;
        }
        public override bool CanExecute(object parameter)
        {
            if (!string.IsNullOrEmpty(noweKontoViewModel.Nazwa) && noweKontoViewModel.SelectedRodzajKonta != null) return true;
            return false;
        }
        public override void Execute(object parameter)
        {
            noweKontoViewModel.bankk.NoweKonto(noweKontoViewModel.Nazwa, noweKontoViewModel.SelectedRodzajKonta);
            if (noweKontoViewModel.UpdateView.CanExecute(null))
                noweKontoViewModel.UpdateView.Execute("Home");
        }
    }
}
