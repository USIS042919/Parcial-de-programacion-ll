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
    public partial class busqueda_peliculas : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _idPelicula;
        public busqueda_peliculas()
        {
            InitializeComponent();
        }
        void filtrar_datos(String valor)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = grdBusquedaPeliculas.DataSource;
            bs.Filter = "Nombre like '%" + valor + "%'";
            grdBusquedaPeliculas.DataSource = bs;
        }

      

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaPeliculas.RowCount > 0)
            {
                _idPelicula = int.Parse(grdBusquedaPeliculas.CurrentRow.Cells[0].Value.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("NO hay datos que seleccionar", "Busqueda de peliculas",
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

        private void busqueda_peliculas_Load(object sender, EventArgs e)
        {
            grdBusquedaPeliculas.DataSource =
             objConexion.obtener_datos().Tables["peliculas"].DefaultView;
        }
    }
}
