using Chart.ViewModels;
using System;
using System.Windows.Input;

namespace Chart.Commands
{
    internal class CustomerUpdateCommand : ICommand
    {
        public CustomerUpdateCommand(CustomerViewModel viewModel)
        {
            _viewModel = viewModel;
        }
        private CustomerViewModel _viewModel;

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested +=value; }
            remove { CommandManager.RequerySuggested -=value; }
        }

        public bool CanExecute(object parameter)
        {
            return _viewModel.CanUpdate;
        }

        public void Execute(object? parameter)
        {
            _viewModel.SaveChanges();
        }
    }
}
