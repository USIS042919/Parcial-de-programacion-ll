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
    public partial class frmBusquedaConsumidor : Form
    {
        Conexion_db objConexion = new Conexion_db();
        public int _idconsumidor;
        public frmBusquedaConsumidor()
        {
            InitializeComponent();
        }

        private void frmBusquedaConsumidor_Load(object sender, EventArgs e)
        {
            grdBusquedaConsumidor.DataSource =
              objConexion.obtener_datos().Tables["categorias"].DefaultView;
        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            if (grdBusquedaConsumidor.RowCount > 0)
            {
                _idconsumidor= int.Parse(grdBusquedaConsumidor.CurrentRow.Cells[0].Value.ToString());
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
            bs.DataSource = grdBusquedaConsumidor.DataSource;
            bs.Filter = "caracteristicas like '%" + valor + "%'";
            grdBusquedaConsumidor.DataSource = bs;

        }
    }
}
