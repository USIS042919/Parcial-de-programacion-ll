using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Parcial_de_programacion_ll
{
    class Conexion_db
    {
        SqlConnection miConexion = new SqlConnection();
        SqlCommand comandosSQL = new SqlCommand();
        SqlDataAdapter miAdaptadorDatos = new SqlDataAdapter();

        DataSet ds = new DataSet();

        public Conexion_db()
        {
            String cadena = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\sistema_db.mdf;Integrated Security=True";
            miConexion.ConnectionString = cadena;
            miConexion.Open();
        }
        public DataSet obtener_datos()
        {
            ds.Clear();
            comandosSQL.Connection = miConexion;

            comandosSQL.CommandText = "select * from clientes";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "clientes");

            comandosSQL.CommandText = "select * from peliculas ";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "peliculas");

            comandosSQL.CommandText = "select * from alquiler ";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "alquiler");

            comandosSQL.CommandText = "select Categorias.opciones, alquiler.idAlquiler,alquiler.idConexion, alquiler.idPelicula,alquiler.fechaPrestamo, alquiler.fechaDevolucion, alquiler.valor," +
                " alquiler.idConexion from alquiler inner join Categorias on(Categorias.idConexion=alquiler.idConexion)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "alquiler_categorias");

            comandosSQL.CommandText = "select * from categorias ";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "categorias");

            comandosSQL.CommandText = "select peliculas.descripcion, alquiler.idAlquiler,alquiler.idConexion, alquiler.idPelicula,alquiler.fechaPrestamo, alquiler.fechaDevolucion, alquiler.valor," +
                " alquiler.idConexion from alquiler inner join peliculas on(peliculas.idPelicula=alquiler.idPelicula)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "alquiler_peliculas");

            comandosSQL.CommandText = "select categorias.opciones, alquiler.fechaPrestamo, alquiler.fechaDevolucion,  alquiler.valor," +
           " peliculas.genero " + " from alquiler " + " inner join categorias on(categorias.idConexion = alquiler.idConexion)" +
           " inner join peliculas on(peliculas.idPelicula = alquiler.idPelicula)";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "Alquiler_clientes_peliculas");

            comandosSQL.CommandText = "select * from movie ";
            miAdaptadorDatos.SelectCommand = comandosSQL;
            miAdaptadorDatos.Fill(ds, "movie");

            return ds;
        }
        public void mantenimiento_datos_alquiler(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO alquiler (idConexion,idPelicula,fechaPrestamo,fechaDevolucion,valor) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE alquiler SET " +
                    "idConexion     = '" + datos[1] + "'," +
                     "idPelicula     = '" + datos[2] + "'," +
                    "fechaPrestamo   = '" + datos[3] + "'," +
                    "fechaDevolucion = '" + datos[4] + "'," +
                    "valor     = '" + datos[5] + "'" +
                    "WHERE idAlquiler = '" + datos[0] + "'";
            }
            else if (accion == "eliminar")
            {
                sql = "DELETE alquiler FROM alquiler WHERE idAlquiler='" + datos[0] + "'";
            }
            procesarSQL(sql);
        }

        public void mantenimiento_datos_clientes(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO clientes (codigo,nombre,direccion,telefono,dui) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE clientes SET " +
                    "codigo         = '" + datos[1] + "'," +
                    "nombre         = '" + datos[2] + "'," +
                    "direccion      = '" + datos[3] + "'," +
                    "telefono       = '" + datos[4] + "'," +
                    "dui         = '" + datos[5] + "'" +
                    "WHERE idCliente = '" + datos[0] + "'";

            }
            else if (accion == "eliminar")
            {
                sql = "DELETE clientes FROM clientes WHERE idCliente='" + datos[0] + "'";

            }
            procesarSQL(sql);
        }
        public void mantenimiento_datos_peliculas(String[] datos, String accion)
        {
            String sql = "";
            if (accion == "nuevo")
            {
                sql = "INSERT INTO peliculas (codigo,descripcion,sinopsis,genero,duracion) VALUES(" +
                    "'" + datos[1] + "'," +
                    "'" + datos[2] + "'," +
                    "'" + datos[3] + "'," +
                    "'" + datos[4] + "'," +
                    "'" + datos[5] + "'" +
                    ")";
            }
            else if (accion == "modificar")
            {
                sql = "UPDATE peliculas SET " +
                    "codigo         = '" + datos[1] + "'," +
                    "descripcion         = '" + datos[2] + "'," +
                    "sinopsis      = '" + datos[3] + "'," +
                    "genero       = '" + datos[4] + "'," +
                    "duracion        = '" + datos[5] + "'" +
                    "WHERE idPelicula = '" + datos[0] + "'";

            }
            else if (accion == "eliminar")
            {
                sql = "DELETE peliculas FROM peliculas WHERE idPelicula='" + datos[0] + "'";

            }
            procesarSQL(sql);
        }

      

        void procesarSQL(String sql)
        {
            comandosSQL.Connection = miConexion;
            comandosSQL.CommandText = sql;
            comandosSQL.ExecuteNonQuery();
        }
    }
}
