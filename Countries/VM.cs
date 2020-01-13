using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Countries
{
    class COUNTRY
    {
        public string Name { get; set; }
        public string CapitalCity { get; set; }
        public COUNTRY (string n, string c) { Name = n; CapitalCity = c; }
    }
    class VM : INotifyPropertyChanged
    {
        public VM()
        {
            myValue = "ECE Paris";

            M model = new M();

            collection = new ObservableCollection<COUNTRY>();
            foreach(KeyValuePair<string, string> a in model.GetCountries())
            {
                COUNTRY c = new COUNTRY(a.Key, a.Value);
                collection.Add(c);
            }


        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        
        private string myValue;
        public string MyValue
        {
            get { return this.myValue; }
            set
            {
                this.myValue = value;
                OnPropertyChanged("MyValue");
            }
        }

        private COUNTRY selectedCountry;
        public COUNTRY SelectedCountry
        {
            get { return this.selectedCountry; }
            set
            {
                this.selectedCountry = value;
            }
        }

        private ObservableCollection<COUNTRY> collection;
        public ObservableCollection<COUNTRY> Collection
        {
            get { return this.collection; }
            set { this.collection = value; }
        }

    }
}
