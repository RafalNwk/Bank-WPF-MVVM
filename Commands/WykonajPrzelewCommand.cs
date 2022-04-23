using Bank.ViewModels;

namespace Bank.Commands
{
    public class WykonajPrzelewCommand : CommandBase
    {
        private readonly PrzelewyViewModel przelewyViewModel;
        public WykonajPrzelewCommand(PrzelewyViewModel przelewyViewModel)
        {
            this.przelewyViewModel = przelewyViewModel;
        }
        public override bool CanExecute(object parameter)
        {
            bool isFloat = float.TryParse(przelewyViewModel.Kwota, out float kwota);
            if (!isFloat ||
                kwota <= 0 ||
                kwota > przelewyViewModel.SelectedKontoZ.saldoKonta ||
                przelewyViewModel.SelectedKontoZ.saldoKonta <= 0 ||
                przelewyViewModel.SelectedKontoZ == przelewyViewModel.SelectedKontoDo)
                return false;
            return true;
        }
        public override void Execute(object parameter)
        {
            przelewyViewModel.SelectedKontoZ.saldoKonta -= float.Parse(przelewyViewModel.Kwota);
            przelewyViewModel.SelectedKontoDo.saldoKonta += float.Parse(przelewyViewModel.Kwota);
            if (przelewyViewModel.UpdateView.CanExecute(null))
                przelewyViewModel.UpdateView.Execute("Home");
        }
    }
}
