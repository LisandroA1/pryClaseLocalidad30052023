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
    class clsCultivo
    {
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;
        public clsCultivo()
        {
            conector = new OleDbConnection("provider=microsoft.jet.oledb.4.0;data source=AGRICULTURA.mdb");
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Cultivos";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = tabla.Columns["cultivo"];
            tabla.PrimaryKey = dc;
        }

        public void ver(ComboBox combo)
        {
            combo.DisplayMember = "nombre";
            combo.ValueMember = "cultivo";
            combo.DataSource = tabla;
        }
        public DataTable getCultivo()
        {
            return tabla;
        }
    }
}
