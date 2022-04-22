using Bank.ViewModels;
using Microsoft.VisualBasic;
using System.Windows;

namespace Bank.Commands
{
    public class WyplacCommand : CommandBase
    {
        private readonly MainViewModel mainViewModel;
        public WyplacCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }
        public override void Execute(object parameter)
        {
            float piniadz = 0;
            float stanKonta = float.Parse(mainViewModel.SaldoKonta);
            bool x = float.TryParse(Interaction.InputBox($"Podaj kwotę którą chcesz wypłacić (Max: {stanKonta}PLN):", "Wypłata", "100"), out piniadz);
            if (piniadz > stanKonta)
            {
                piniadz = stanKonta;
            }
            if (x && piniadz != 0)
            {
                mainViewModel.bankk.Wyplata(mainViewModel.SelectedKonto.id, piniadz);
                mainViewModel.SaldoKontaChanged();
                MessageBox.Show($"Udało się wypłacić {piniadz}PLN. Twój aktualny stan konta: {mainViewModel.SaldoKonta.ToString()}PLN");
            }
            else
            {
                if (x && piniadz == 0) MessageBox.Show($"Kwota musi być różna od zera");
                else MessageBox.Show($"Nie udało się dokonać wypłaty.");
            }
        }
    }
}
