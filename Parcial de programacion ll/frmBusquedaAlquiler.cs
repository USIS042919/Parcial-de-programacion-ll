using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial_de_programacion_ll
{
    public partial class frmBusquedaAlquiler : Form
    {
         Conexion_db objConexion = new Conexion_db();
        public int _idAlquiler;
        public frmBusquedaAlquiler()
        {
            InitializeComponent();
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaAlquiler.RowCount > 0)
            {
                _idAlquiler = int.Parse(grdBusquedaAlquiler.CurrentRow.Cells["idAlquiler"].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de alquiler",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            filtrar_datos(txtbuscar.Text);
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBusquedaAlquiler_Load(object sender, EventArgs e)
        {
            grdBusquedaAlquiler.DataSource = objConexion.obtener_datos().Tables["Alquiler_clientes_peliculas"].DefaultView;
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaAlquiler.DataSource;
            bs.Filter = "codigo like '%" + valor + "%'";
            grdBusquedaAlquiler.DataSource = bs;
        }
    }
}
