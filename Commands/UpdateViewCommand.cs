using KasperskyInternetSecurity.ViewModels;
using System;
using System.Windows.Input;

namespace KasperskyInternetSecurity.Commands
{
    public class UpdateViewCommand : ICommand
    {
        private MainViewModel viewModel;

        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            switch (parameter)
            {
                case "Safety":
                    viewModel.SelectedViewModel = new SafetyViewModel();
                    break;

                case "Network":
                    viewModel.SelectedViewModel = new NetworkViewModel();
                    break;

                case "Optimization":
                    viewModel.SelectedViewModel = new OptimizationViewModel();
                    break;

                case "ProgramControl":
                    viewModel.SelectedViewModel = new ProgramControlViewModel();
                    break;
                    
                default:
                    break;
            }
        }
    }
}
