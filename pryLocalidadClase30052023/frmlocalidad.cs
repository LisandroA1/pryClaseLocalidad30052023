using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms.DataVisualization.Charting;

namespace pryLocalidadClase30052023
{
    public partial class frmlocalidad : Form
    {
        public frmlocalidad()
        {
            InitializeComponent();
        }
        clsLocalidad localidad;
        clsCultivo cultivo;
        clsProduccion produccion;

        private void tabPage1_Click(object sender, EventArgs e)
        {
            


        }

        private void frmlocalidad_Load(object sender, EventArgs e)
        {
            localidad = new clsLocalidad();
            cultivo = new clsCultivo();
            produccion = new clsProduccion();

            localidad.ver(lstLocalidad);
            cultivo.ver(lstCultivo);
            localidad.ver(lsbLocalidad);

            
        }

        private void cmdGraficar_Click(object sender, EventArgs e)
        {
            //limpio el grafico
            chtGraficoLocalidad.Series.Clear();
            clsProduccion objProduccion = new clsProduccion();
            objProduccion.graficar((int)lsbLocalidad.SelectedValue, chtGraficoLocalidad);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool valor = produccion.Actualizar((int)lstLocalidad.SelectedValue, (int)lstCultivo.SelectedValue, Convert.ToInt32(txtToneladas.Text));
            if (valor == true)
            {
                txtToneladas.Text = "";
                MessageBox.Show("Datos cargdos con exito", "AVISO");
            }
            else
            {
                MessageBox.Show("Estos datos ya estan registrados...", "ERROR");
            }
        }
    }
}
