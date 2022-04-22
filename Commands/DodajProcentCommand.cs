using Bank.ViewModels;

namespace Bank.Commands
{
    public class DodajProcentCommand : CommandBase
    {
        private readonly MainViewModel mainViewModel;
        public DodajProcentCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }
        public override void Execute(object parameter)
        {
            mainViewModel.bankk.DoliczOprocentowanie(mainViewModel.SelectedKonto.id);
            mainViewModel.SaldoKontaChanged();
        }
    }
}
