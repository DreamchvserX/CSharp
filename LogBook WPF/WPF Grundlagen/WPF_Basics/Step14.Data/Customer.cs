using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace DataApplication
{
    
    public class Customer : INotifyPropertyChanged
    {
        public Customer()
        {
        }

        public Customer(string name, DateTime created)
        {
            this.name = name;
            this.created = created;
        }

        private string name;
        private DateTime created;

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

        public DateTime Created
        {
            get
            {
                return created;
            }
        }

        public Customer[] GetCustomers(string v)
        {
            Random r = new Random();

            int count = 0;
            Int32.TryParse(v, out count);
            List<Customer> result = new List<Customer>();
            for (int i = 0; i < count; i++)
                result.Add(new Customer("Customer #" + i, DateTime.Now - TimeSpan.FromDays(r.Next(10, 8000))));
            return result.ToArray();
        }

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
    }

}
