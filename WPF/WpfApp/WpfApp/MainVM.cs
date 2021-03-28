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
    public class MainVM : ViewModelBase
    {
        public MainVM()
        {
            this.PropertyChanged += MainVM_PropertyChanged;
            GameData = new ObservableCollection<Data>();
            Game = new ObservableCollection<string>();


            CMD_New = new RelayCommand(() => { Selected = new Data(); }, () => Selected is null || GameData.Contains(Selected));

            CMD_Add = new RelayCommand(() => { GameData.Add(Selected); Selected = null; }, () => !GameData.Contains(Selected) && SelectedNotNull);

            CMD_Clear = new RelayCommand(() => { GameData.Clear(); }, () => GameData.Count > 0);

            CMD_Remove = new RelayCommand(() => { GameData.Remove(Selected); }, () => SelectedNotNull && GameData.Contains(Selected));

        }

        private void MainVM_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {

            switch (e.PropertyName)
            {
                case "Selected":
                    SelectedNotNull = Selected != null;
                    break;
                default:
                    break;
            }
        }
        private bool selectedNotNull;
        private string input;
        private string output;
        private Data selected;
        public string Input { get => input; set => Set(ref input, value); }
        public string Output { get => output; set => Set(ref output, value); }
        public Data Selected { get => selected; set => Set(ref selected, value); }
        public bool SelectedNotNull { get => selectedNotNull; set => Set(ref selectedNotNull, value); }
        public ICommand CMD_Clear { get; set; }
        public ICommand CMD_Add { get; set; }
        public ICommand CMD_Remove { get; set; }
        public ICommand CMD_New { get; set; }
        private bool ClearCanExecute()
        {
            return GameData.Count > 0;
        }

        public ObservableCollection<string> Game { get; private set; }
        public ObservableCollection<Data> GameData { get; private set; }
    }
}
