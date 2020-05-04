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
    public partial class alquiler : Form
    {
        Conexion_db objConexion = new Conexion_db();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public alquiler()
        {
            InitializeComponent();
        }

        private void btnprimero_Click(object sender, EventArgs e)
        {
            posicion = 0;
            mostrarDatos();
        }

        private void btnanterior_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Primer Registro...", "Registros de Alquiler",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnsiguiente_Click(object sender, EventArgs e)
        {

            if (posicion < tbl.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ultimo Registro...", "Registros de Alquiler",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnultimo_Click(object sender, EventArgs e)
        {
            posicion = tbl.Rows.Count - 1;
            mostrarDatos();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (btnNuevo.Text == "Nuevo")
            {//boton de nuevo
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "nuevo";

                limpiar_cajas();
                controles(false);
            }
            else
            { //boton de guardar
                String[] valores = {
                    cboCategoriaClientes.SelectedValue.ToString(),
                    cboCategoriaPeliculas.SelectedValue.ToString(),
                    txtprestamo.Text,
                    txtdevolucion.Text,
                    txtvalor.Text
                };
                objConexion.mantenimiento_datos_alquiler(valores, accion);
                actualizarDs();
                posicion = tbl.Rows.Count - 1;
                mostrarDatos();

                controles(true);

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (btnModificar.Text == "Modificar")
            {//boton de modificar
                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";
                accion = "modificar";

                controles(false);

                btnNuevo.Text = "Guardar";
                btnModificar.Text = "Cancelar";

            }
            else
            { //boton de cancelar
                controles(true);
                mostrarDatos();

                btnNuevo.Text = "Nuevo";
                btnModificar.Text = "Modificar";
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de elimina a " + txtprestamo.Text, "Registro de Alquiler",
              MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidAlquiler.Text };
                objConexion.mantenimiento_datos_alquiler(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaAlquiler buscarAlquiler = new frmBusquedaAlquiler();
            buscarAlquiler.ShowDialog();

            if (buscarAlquiler._idAlquiler > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(buscarAlquiler._idAlquiler));
                mostrarDatos();
            }
        }

        private void alquiler_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();

            cboCategoriaClientes.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCategoriaClientes.AutoCompleteSource = AutoCompleteSource.ListItems;

            cboCategoriaPeliculas.AutoCompleteMode = AutoCompleteMode.Suggest;
            cboCategoriaPeliculas.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["alquiler"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idAlquiler"] };

            cboCategoriaClientes.DataSource = objConexion.obtener_datos().Tables["categorias"];
            cboCategoriaClientes.DisplayMember = "opciones";
            cboCategoriaClientes.ValueMember = "categorias.idConexion";

            cboCategoriaPeliculas.DataSource = objConexion.obtener_datos().Tables["peliculas"];
            cboCategoriaPeliculas.DisplayMember = "genero";
            cboCategoriaPeliculas.ValueMember = "peliculas.idPelicula";
        }
        void mostrarDatos()
        {
            try
            {
                cboCategoriaClientes.SelectedValue = tbl.Rows[posicion].ItemArray[1].ToString();
                cboCategoriaPeliculas.SelectedValue = tbl.Rows[posicion].ItemArray[2].ToString();
                lblidAlquiler.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtprestamo.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtdevolucion.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtvalor.Text = tbl.Rows[posicion].ItemArray[5].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar " + ex.Message, "Registros de Alquiler",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }
        }
        void limpiar_cajas()
        {
            
            txtprestamo.Text = "";
            txtdevolucion.Text = "";
            txtvalor.Text = "";
        }
        void controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosAlquiler.Enabled = !valor;
        }

        private void btnBuscarCategoriaCliente_Click(object sender, EventArgs e)
        {
            frmBusquedaConsumidor buscarCategorias= new frmBusquedaConsumidor();
            buscarCategorias.ShowDialog();

            if (buscarCategorias._idconsumidor > 0)
            {
                cboCategoriaClientes.SelectedValue = buscarCategorias._idconsumidor;
            }
        }

        private void btnBuscarCategoriaPelicula_Click(object sender, EventArgs e)
        {
            frmBusquedaMovie buscarMovie = new frmBusquedaMovie();
            buscarMovie.ShowDialog();

            if (buscarMovie._idmovie > 0)
            {
                cboCategoriaPeliculas.SelectedValue = buscarMovie._idmovie;
            }
        }
    }
}
