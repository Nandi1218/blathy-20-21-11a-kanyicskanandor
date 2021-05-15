using DataBase.Data;
using DataBase.Model;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace DataBase 
{
    class MainVM : ViewModelBase
    {
        private Game selected;
        public MainVM()
        {
            Games = new ObservableCollection<Game>();
            CMD_New = new RelayCommand(New, NewCanExecute);
            CMD_Delete = new RelayCommand(Del, DelCanExecute);
            CMD_Save = new RelayCommand(Save, SaveCanExecute);
            ctx = new Context();
            foreach (var item in ctx.Games)
            {
                Games.Add(item);
            }
        }

        Context ctx;

        private void Save()
        {

            try
            {
                if (Selected.ID == 0)
                {
                    ctx.Games.Add(Selected);
                    Games.Add(Selected);
                }
                ctx.SaveChanges();
                Modification = false;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                if (Selected.ID == 0)
                {
                    ctx.Games.Remove(Selected);
                    Games.Remove(Selected);
                }
            }

        }

        private bool SaveCanExecute()
        {
            return Modification;
        }

        private void Del()
        {
            ctx.Games.Remove(Selected);
            ctx.SaveChanges();
            Games.Remove(Selected);
        }

        private bool DelCanExecute()
        {
            return Selected != null;
        }

        private void New()
        {
            Selected = new Game();
        }

        private bool NewCanExecute()
        {
            return !Modification;
        }
        private bool modification;
        public bool Modification { get => modification; set => Set(ref modification, value); }
        public ObservableCollection<Game> Games { get; private set; }
        public Game Selected
        {
            get => selected;
            set
            {
                if (selected != null) selected.PropertyChanged -= Selected_PropertyChanged;
                Set(ref selected, value);
                if (selected != null) selected.PropertyChanged += Selected_PropertyChanged;
            }
        }

        private void Selected_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "Name":
                    Modification = true;
                    break;
                default:
                    break;
            }
        }

        public ICommand CMD_New { get; set; }
        public ICommand CMD_Delete { get; set; }
        public ICommand CMD_Save { get; set; }
    }
}
