using Bank.ViewModels;
using Microsoft.VisualBasic;
using System.Windows;

namespace Bank.Commands
{
    public class WplacCommand : CommandBase
    {
        private readonly HomeViewModel homeViewModel;
        public WplacCommand(HomeViewModel homeViewModel)
        {
            this.homeViewModel = homeViewModel;
        }
        public override bool CanExecute(object parameter)
        {
            if (homeViewModel.SelectedKonto != null) return true;
            return false;
        }
        public override void Execute(object parameter)
        {
            bool x = float.TryParse(Interaction.InputBox("Podaj kwotę którą chcesz wpłacić:", "Wpłata", "100"), out float piniadz);
            if (x && piniadz != 0)
            {
                homeViewModel.bankk.Wplata(homeViewModel.SelectedKonto.id, piniadz);
                homeViewModel.SaldoKontaChanged();
                MessageBox.Show($"Udało się wpłacić {piniadz.ToString("n2")}PLN. Twój aktualny stan konta: {homeViewModel.SaldoKonta}PLN");
            }
            else
            {
                if (x && piniadz == 0) MessageBox.Show($"Kwota musi być różna od zera");
                else MessageBox.Show($"Nie udało się dokonać wpłaty.");
            }
        }
    }
}
