using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace BazarDisp
{
    class BaseDatos
    {
        public BaseDatos()
        {
            FormServidor serv = new FormServidor();
            string conexion = "Provider = Microsoft.Jet.OleDb.4.0;Data Source = C:\\Users\\phili\\OneDrive\\PROYECTO DE DI\\BASE DE DATOS\\BazarDisp.xlsx;Extended Properties = \"Excel 8.0;HDR = Yes\"";
            OleDbConnection conector = default(OleDbConnection);
            conector = new OleDbConnection(conexion);
            conector.Open();
            // 
            OleDbCommand consulta = default(OleDbCommand);
            consulta = new OleDbCommand("SELECT * FROM [Hoja1$]", conector);
            //
            OleDbDataAdapter adaptador = new OleDbDataAdapter();
            adaptador.SelectCommand = consulta;
            //
            DataSet ds = new DataSet();
            adaptador.Fill(ds);
            serv.txtbServidor.Text = "" + ds.Tables[0];
            //
            conector.Close();
        }
    }
}
