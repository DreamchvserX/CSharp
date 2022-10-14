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
    public class Zwecke
    {

        BAL? balObj;
        private int id;
        private string zweck;

        public int ID

        {
            get { return id; }
            set { id = value; }
        }

        public string Zweck
        {
            get { return zweck; }
            set { zweck = value; }
        }

        public Zwecke()
        {
            balObj = new BAL();
        }



        public ObservableCollection<String> getZweckeNames()
        {
            ObservableCollection<String> temp = new ObservableCollection<String>();

            foreach (DataRow row in balObj.getZwecke().Rows)
            {
                temp.Add((String)row[1] + " " + (String)row[2]);
            }

            return temp;

        }


        public ObservableCollection<Zwecke> getZwecke()
        {
            ObservableCollection<Zwecke> temp = new ObservableCollection<Zwecke>();
            foreach (DataRow row in balObj.getZwecke().Rows)
            {
                Zwecke f = new Zwecke();
                f.zweck = (String)row[1];
                f.id = (int)row[0];
                temp.Add(f);
            }

            return temp;

        }
    }
}
