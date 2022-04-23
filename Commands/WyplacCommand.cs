using Bank.ViewModels;
using Microsoft.VisualBasic;
using System.Windows;

namespace Bank.Commands
{
    public class WyplacCommand : CommandBase
    {
        private readonly HomeViewModel homeViewModel;
        public WyplacCommand(HomeViewModel homeViewModel)
        {
            this.homeViewModel = homeViewModel;
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
            float stanKonta = float.Parse(homeViewModel.SaldoKonta);
            bool x = float.TryParse(Interaction.InputBox($"Podaj kwotę którą chcesz wypłacić (Max: {stanKonta}PLN):", "Wypłata", "100"), out float piniadz);
            if (piniadz > stanKonta)
            {
                piniadz = stanKonta;
            }
            if (x && piniadz != 0)
            {
                homeViewModel.bankk.Wyplata(homeViewModel.SelectedKonto.id, piniadz);
                homeViewModel.SaldoKontaChanged();
                MessageBox.Show($"Udało się wypłacić {piniadz.ToString("n2")}PLN. Twój aktualny stan konta: {homeViewModel.SaldoKonta}PLN");
            }
            else
            {
                if (x && piniadz == 0) MessageBox.Show($"Kwota musi być różna od zera");
                else MessageBox.Show($"Nie udało się dokonać wypłaty.");
            }
        }
    }
}
