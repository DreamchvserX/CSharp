using Lb.BACLayer;
using System;
using System.Collections.ObjectModel;
using System.Data;

namespace Lb.BELayer
{

    public class Fahrer
    {

        BAL? balObj;
        private int id;
        private string name1;
        private string name2;
        public int ID

        {
            get { return id; }
            set { id = value; }
        }

        public string Nachname
        {
            get { return name2; }
            set { name2 = value; }
        }

        public string Vorname
        {
            get { return name1; }
            set { name1 = value; }
        }

        public Fahrer()
        {
            balObj = new BAL();
        }




        public ObservableCollection<String> getFahrerNames()
        {
            ObservableCollection<String> temp = new ObservableCollection<String>();

            foreach (DataRow row in balObj.getFahrer().Rows)
            {
                temp.Add((String)row[1] + " " + (String)row[2]);
            }

            return temp;

        }


        public ObservableCollection<Fahrer> getFahrers()
        {
            ObservableCollection<Fahrer> temp = new ObservableCollection<Fahrer>();
            foreach (DataRow row in balObj.getFahrer().Rows)
            {
                Fahrer f = new Fahrer();
                f.name1 = (String)row[1];
                f.name2 = (String)row[2];
                f.id = (int)row[0];
                temp.Add(f);
            }

            return temp;

        }
    }
}
