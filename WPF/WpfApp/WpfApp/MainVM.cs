using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp
{
    class MainVM : ViewModelBase
    {
        public MainVM()
        {
            GameName = new ObservableCollection<string>();
            Developer = new ObservableCollection<string>();
            Publisher = new ObservableCollection<string>();
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
            string[] temp = Input.Split(';');

            GameName.Add(temp[0]);
            Developer.Add(temp[1]);
            Publisher.Add(temp[2]);
            Input = "";
        }
        private bool AddCanExecute()
        {
            char c = ';';
            if (!string.IsNullOrWhiteSpace(Input) && !(Input.Last() == c))
            {
                if ((Regex.Matches(Input, ";").Count) == 2)
                {
                    return true;
                }
            }

            return false;
            // return !string.IsNullOrWhiteSpace(Input);
        }
        private void Clear()
        {
            GameName.Clear();
            Developer.Clear();
            Publisher.Clear();
        }
        private bool ClearCanExecute()
        {
            return GameName.Count > 0;
        }
        public ObservableCollection<string> GameName { get; private set; }
        public ObservableCollection<string> Developer { get; private set; }
        public ObservableCollection<string> Publisher { get; private set; }
    }
}
