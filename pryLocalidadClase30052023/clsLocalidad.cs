using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

using System.Windows.Forms;

namespace pryLocalidadClase30052023
{
    class clsLocalidad
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        public clsLocalidad()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=AGRICULTURA.mdb");
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Localidades";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["localidad"];
            tabla.PrimaryKey = dc;
        }

        public void ver(ComboBox combo)
        {
            combo.DisplayMember = "nombre";
            combo.ValueMember = "localidad";
            combo.DataSource = tabla;
        }

        public void ver(ListBox lb)
        {
            lb.DisplayMember = "nombre";
            lb.ValueMember = "localidad";
            lb.DataSource = tabla;
        }
    }
}
