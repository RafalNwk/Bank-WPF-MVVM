using Bank.ViewModels;

namespace Bank.Commands
{
    public class DodajProcentCommand : CommandBase
    {
        private readonly HomeViewModel homeViewModel;
        public DodajProcentCommand(HomeViewModel mainViewModel)
        {
            this.homeViewModel = mainViewModel;
        }
        public override bool CanExecute(object parameter)
        {
            if (homeViewModel.SelectedKonto != null)
            {
                if (homeViewModel.SelectedKonto.saldoKonta > 0) return true;
            }

            return false;
        }
        public override void Execute(object parameter)
        {
            homeViewModel.bankk.DoliczOprocentowanie(homeViewModel.SelectedKonto.id);
            homeViewModel.SaldoKontaChanged();
        }
    }
}
