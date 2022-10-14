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
    public class Fahrzeuge
    {

        BAL? balObj;
        private int id;
        private string typ;
        private string kennzeichen;
        public int ID

        {
            get { return id; }
            set { id = value; }
        }

        public string Typ
        {
            get { return typ; }
            set { typ = value; }
        }

        public string Kennzeichen
        {
            get { return kennzeichen; }
            set { kennzeichen = value; }
        }

        public Fahrzeuge()
        {
            balObj = new BAL();
        }




        public ObservableCollection<String> getFahrzeugeNames()
        {
            ObservableCollection<String> temp = new ObservableCollection<String>();

            foreach (DataRow row in balObj.getFahrzeug().Rows)
            {
                temp.Add((String)row[1] + " " + (String)row[2]);
            }

            return temp;

        }


        public ObservableCollection<Fahrzeuge> getFahrzeuge()
        {
            ObservableCollection<Fahrzeuge> temp = new ObservableCollection<Fahrzeuge>();
            foreach (DataRow row in balObj.getFahrzeug().Rows)
            {
                Fahrzeuge f = new Fahrzeuge();
                f.typ = (String)row[1];
                f.kennzeichen = (String)row[2];
                f.id = (int)row[0];
                temp.Add(f);
            }

            return temp;

        }
    }
}
