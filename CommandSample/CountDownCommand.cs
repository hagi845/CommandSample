using System;
using System.Windows.Input;

namespace CommandSample
{
    public class CountDownCommand : ICommand
    {
        private CounterViewModel _viewModel { get; set; }

        public CountDownCommand(CounterViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _viewModel.Value = (_viewModel.Value <= 0) ? 100 : _viewModel.Value - 1;
        }
    }

}
