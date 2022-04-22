using Bank.ViewModels;
using Microsoft.VisualBasic;
using System.Windows;

namespace Bank.Commands
{
    public class WplacCommand : CommandBase
    {
        private readonly MainViewModel mainViewModel;
        public WplacCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }
        public override void Execute(object parameter)
        {
            float piniadz = 0;
            bool x = float.TryParse(Interaction.InputBox("Podaj kwotę którą chcesz wpłacić:", "Wpłata", "100"), out piniadz);
            if (x && piniadz != 0)
            {
                mainViewModel.bankk.Wplata(mainViewModel.SelectedKonto.id, piniadz);
                mainViewModel.SaldoKontaChanged();
                MessageBox.Show($"Udało się wpłacić {piniadz}PLN. Twój aktualny stan konta: {mainViewModel.SaldoKonta.ToString()}PLN");
            }
            else
            {
                if(x && piniadz == 0) MessageBox.Show($"Kwota musi być różna od zera");
                else MessageBox.Show($"Nie udało się dokonać wpłaty.");
            }
        }
    }
}
