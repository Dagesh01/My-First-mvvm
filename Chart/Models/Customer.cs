
namespace Chart.Models
{
    using System;
    using System.ComponentModel;

    public class Customer : INotifyPropertyChanged
    {
        public Customer(string CustomerName)
        {
            Name = CustomerName;
        }
        private string _Name;
        public string Name { 
            get
            { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }
        #region Inotify Members
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
    
}

