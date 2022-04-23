using Bank.Commands;
using Bank.Models;
using System.Windows.Input;

namespace Bank.ViewModels
{
    public class MainWindowModel : ViewModelBase
    {
        private ViewModelBase _selectedViewModel;
        public ViewModelBase SelectedViewModel
        {
            get { return _selectedViewModel; }
            set
            {
                _selectedViewModel = value;
                OnPropertyChanged(nameof(SelectedViewModel));
            }
        }
        public static Bankk bank = new Bankk();
        public static ICommand UpdateView { get; set; }

        public MainWindowModel()
        {
            UpdateView = new UpdateViewCommand(this);
            if (bank.konta.Count == 0) SelectedViewModel = new NoweKontoViewModel(bank);
            else SelectedViewModel = new HomeViewModel(bank);
        }
    }
}
