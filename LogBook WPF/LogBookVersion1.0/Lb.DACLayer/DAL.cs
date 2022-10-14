using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace Lb.DACLayer
{
    public class DAL
    {
        SqlConnection? con;
        SqlCommand? cmd;
        DataSet? ds;

        public DAL()
        {

        }

        string getConnection() {
            return "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\justi\\Desktop\\Office\\School\\C#\\LogBook WPF\\LogBookVersion1.0\\Lb.DACLayer\\LogBookDB.mdf\";Integrated Security=True";
        }

        public DataTable? getFahrer()
        {
            using (con = new SqlConnection(getConnection()))
            {
                con.Open();
                using (cmd = new SqlCommand("SELECT * from dbo.fahrer", con))
                {
                    cmd.Connection = con;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    ds = new DataSet();
                    da.Fill(ds, "fahrer");
                }

            }

            return ds.Tables["fahrer"];

        }

        public DataTable? getFahrzeug()
        {
            using (con = new SqlConnection(getConnection()))
            {
                con.Open();
                using (cmd = new SqlCommand("SELECT * from dbo.fahrzeuge", con))
                {
                    cmd.Connection = con;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    ds = new DataSet();
                    da.Fill(ds, "fahrzeuge");
                }

            }

            return ds.Tables["fahrzeuge"];

        }


        public DataTable? getOrte()
        {
            using (con = new SqlConnection(getConnection()))
            {
                con.Open();
                using (cmd = new SqlCommand("SELECT * from dbo.orte", con))
                {
                    cmd.Connection = con;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    ds = new DataSet();
                    da.Fill(ds, "orte");
                }

            }

            return ds.Tables["orte"];

        }

        public DataTable? getZwecke()
        {
            using (con = new SqlConnection(getConnection()))
            {
                con.Open();
                using (cmd = new SqlCommand("SELECT * from dbo.zwecke", con))
                {
                    cmd.Connection = con;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    ds = new DataSet();
                    da.Fill(ds, "zwecke");
                }

            }

            return ds.Tables["zwecke"];

        }

    }
}
