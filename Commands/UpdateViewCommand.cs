﻿using KasperskyInternetSecurity.ViewModels;
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
            if (parameter.ToString() == "Safety")
            {
                viewModel.SelectedViewModel = new SafetyViewModel();
            }
            else if (parameter.ToString() == "Network")
            {
                viewModel.SelectedViewModel = new NetworkViewModel();
            }
        }
    }
}
