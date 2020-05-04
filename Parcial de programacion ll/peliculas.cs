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
    public partial class peliculas : Form
    {
        Conexion_db objConexion = new Conexion_db();
        int posicion = 0;
        string accion = "nuevo";
        DataTable tbl = new DataTable();
        public peliculas()
        {
            InitializeComponent();
        }

        void actualizarDs()
        {
            tbl = objConexion.obtener_datos().Tables["peliculas"];
            tbl.PrimaryKey = new DataColumn[] { tbl.Columns["idPelicula"] };
        }
        void mostrarDatos()
        {
            try
            {
                lblidPelicula.Text = tbl.Rows[posicion].ItemArray[0].ToString();
                txtcodigo.Text = tbl.Rows[posicion].ItemArray[1].ToString();
                txtdescripcion.Text = tbl.Rows[posicion].ItemArray[2].ToString();
                txtsinopsis.Text = tbl.Rows[posicion].ItemArray[3].ToString();
                txtgenero.Text = tbl.Rows[posicion].ItemArray[4].ToString();
                txtduracion.Text = tbl.Rows[posicion].ItemArray[5].ToString();

                lblnregistros.Text = (posicion + 1) + " de " + tbl.Rows.Count;

            }
            catch (Exception ex)
            {
                MessageBox.Show("No hay Datos que mostrar", "Registros de peliculas",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar_cajas();
            }



        }

        void limpiar_cajas()
        {
            txtcodigo.Text = "";
            txtdescripcion.Text = "";
            txtsinopsis.Text = "";
            txtgenero.Text = "";
            txtduracion.Text = "";

        }
        void controles(Boolean valor)
        {
            grbNavegacion.Enabled = valor;
            btneliminar.Enabled = valor;
            btnBuscar.Enabled = valor;
            grbDatosPeliculas.Enabled = !valor;
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
                MessageBox.Show("Primer Registro...", "Registros de Pelicula",
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
                MessageBox.Show("Ultimo Registro...", "Registros de Pelicula",
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
                    lblidPelicula.Text,
                    txtcodigo.Text,
                    txtdescripcion.Text,
                    txtsinopsis.Text,
                    txtgenero.Text,
                    txtduracion.Text,

                };
                objConexion.mantenimiento_datos_peliculas(valores, accion);
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
            if (MessageBox.Show("Esta seguro de elimina a " + txtdescripcion.Text, "Registro de peliculas",
           MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
            {
                String[] valores = { lblidPelicula.Text };
                objConexion.mantenimiento_datos_peliculas(valores, "eliminar");

                actualizarDs();
                posicion = posicion > 0 ? posicion - 1 : 0;
                mostrarDatos();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            busqueda_peliculas frmBusquedaPeliculas = new busqueda_peliculas();
            frmBusquedaPeliculas.ShowDialog();

            if (frmBusquedaPeliculas._idPelicula > 0)
            {
                posicion = tbl.Rows.IndexOf(tbl.Rows.Find(frmBusquedaPeliculas._idPelicula));
                mostrarDatos();
            }
        }

        private void peliculas_Load(object sender, EventArgs e)
        {
            actualizarDs();
            mostrarDatos();
        }
    }
}
