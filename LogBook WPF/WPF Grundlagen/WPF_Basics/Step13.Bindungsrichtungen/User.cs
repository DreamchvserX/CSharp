using System;
using System.ComponentModel;

namespace BindingDirectionApplication
{
    
    public class User : INotifyPropertyChanged
    {
        public User(string name)
        {
            this.name = name;
        }

        private string name;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged(new PropertyChangedEventArgs("Name"));
                }
            }
        }

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
    }

}
