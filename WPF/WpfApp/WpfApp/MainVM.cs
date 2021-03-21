using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp
{
    class MainVM : ViewModelBase
    {
        public MainVM()
        {
            Elements = new ObservableCollection<string>();
            CMD_Clear = new RelayCommand(Clear, ClearCanExecute);
            CMD_Add = new RelayCommand(Add, AddCanExecute);
        }
        private string input;
        private string output;
        public string Input { get => input; set => Set(ref input, value); }
        public string Output { get => output; set => Set(ref output, value); }
        public ICommand CMD_Clear { get; set; }
        public ICommand CMD_Add { get; set; }
        private void Add()
        {
            Elements.Add(Input);
            Input = "";
        }
        private bool AddCanExecute()
        {
            return !string.IsNullOrWhiteSpace(Input);
        }
        private void Clear()
        {
            Elements.Clear();
        }
        private bool ClearCanExecute() 
        {
            return Elements.Count > 0;
        }
        public ObservableCollection<string> Elements { get; private set; }
    }
}
