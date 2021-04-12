using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp
{
    public class Data : ObservableObject
    {
        public Data()
        {
            this.PropertyChanged += Data_PropertyChanged;
        }

        private void Data_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
        }
        private string name;
        private string developer;
        private string publisher;

        public string Name { get => name; set => Set(ref name, value); }
        public string Developer { get => developer; set => Set(ref developer, value); }
        public string Publisher { get => publisher; set => Set(ref publisher, value); }
        

    }
}
