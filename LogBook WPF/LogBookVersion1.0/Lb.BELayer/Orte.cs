using Lb.BACLayer;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb.BELayer
{
    public class Orte
    {

        BAL? balObj;
        private int id;
        private string ort;
    
        public int ID

        {
            get { return id; }
            set { id = value; }
        }

        public string Ort
        {
            get { return ort; }
            set { ort = value; }
        }


        public Orte()
        {
            balObj = new BAL();
        }




        public ObservableCollection<String> getOrteNames()
        {
            ObservableCollection<String> temp = new ObservableCollection<String>();

            foreach (DataRow row in balObj.getOrte().Rows)
            {
                temp.Add((String)row[1] + " " + (String)row[2]);
            }

            return temp;

        }


        public ObservableCollection<Orte> getOrte()
        {
            ObservableCollection<Orte> temp = new ObservableCollection<Orte>();
            foreach (DataRow row in balObj.getOrte().Rows)
            {
                Orte f = new Orte();
                f.Ort = (String)row[1];
                f.id = (int)row[0];
                temp.Add(f);
            }

            return temp;

        }
    }
}