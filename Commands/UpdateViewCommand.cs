using Bank.ViewModels;

namespace Bank.Commands
{
    public class UpdateViewCommand : CommandBase
    {
        private readonly MainWindowModel viewModel;

        public UpdateViewCommand(MainWindowModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            if (parameter.ToString() == "Home")
            {
                viewModel.SelectedViewModel = new HomeViewModel(MainWindowModel.bank);
            }
            if (parameter.ToString() == "NoweKonto")
            {
                viewModel.SelectedViewModel = new NoweKontoViewModel(MainWindowModel.bank);
            }
            if (parameter.ToString() == "Przelewy")
            {
                viewModel.SelectedViewModel = new PrzelewyViewModel(MainWindowModel.bank);
            }
        }
    }
}