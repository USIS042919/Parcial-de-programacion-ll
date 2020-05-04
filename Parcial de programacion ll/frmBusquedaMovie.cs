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
    public partial class frmBusquedaMovie : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _idmovie;
        public frmBusquedaMovie()
        {
            InitializeComponent();
        }

        private void frmBusquedaMovie_Load(object sender, EventArgs e)
        {
            grdBusquedaMovie.DataSource =
              objConexion.obtener_datos().Tables["movie"].DefaultView;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaMovie.RowCount > 0)
            {
                _idmovie = int.Parse(grdBusquedaMovie.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de Clientes",
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
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaMovie.DataSource;
            bs.Filter = "opcion like '%" + valor + "%'";
            grdBusquedaMovie.DataSource = bs;

           
        }
    }
}
