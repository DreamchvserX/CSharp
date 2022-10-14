using Lb.DACLayer;
using System;
using System.Data;
using System.Threading.Tasks.Dataflow;

namespace Lb.BACLayer
{
    public class BAL
    {
        DAL? dalObj;

        public BAL()
        {
            dalObj = new DAL();
        }

        public DataTable? getFahrer()
        {
            return dalObj?.getFahrer();
        }

        public DataTable? getFahrzeug()
        {
            return dalObj?.getFahrzeug();
        }
    
        public DataTable? getOrte()
        {
            return dalObj?.getOrte();
        }

        public DataTable? getZwecke()
        {
            return dalObj?.getZwecke();
        }

    }

}
