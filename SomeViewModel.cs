using System.ComponentModel;
using System.Windows.Input;

namespace DataBinding_Notes_Test
{
    public class SomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private SomeModel Model = new();

        public SomeViewModel()
        {
            ClearTextCommand = new RelayCommand(
                () =>
                {
                    Model.ClearText();
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SomeTextProperty)));
                }
            );
        }

        public string SomeTextProperty
        {
            get { return Model.SomeTextProperty; }
            set { Model.SomeTextProperty = value; }
        }

        public ICommand ClearTextCommand { get; }
    }

    public class RelayCommand : ICommand
    {
        private Action _action;

        public RelayCommand(Action action)
        {
            _action = action;
        }

        public event EventHandler? CanExecuteChanged;

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            _action?.Invoke();
        }
    }
}
