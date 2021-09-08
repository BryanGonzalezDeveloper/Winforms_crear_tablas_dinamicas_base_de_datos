using System;
using System.Data.SqlClient;
using System.Data;
namespace Winforms_crear_tablas_dinamicas_base_de_datos.DB
{
    /// <summary>
    /// Clase encargada de realizar operaciones sobre tablas y sus columnas.
    /// </summary>
    class clsMetodosDB
    {
        /// <summary>
        /// Objeto que representa la conexion hacia la base de datos.
        /// </summary>
        SqlConnection objConexion = new SqlConnection(ClsConexion.getConnectionString);
        /// <summary>
        /// Representacion de una instruccion en sql.
        /// </summary>
        SqlCommand instruccionSQL;


        /// <summary>
        /// Metodo encargado de crear una tabla de forma dinamica en una base de datos
        /// especifica. El requerimiento consiste en generar una tabla con 3 campos (columnas)
        /// </summary>
        /// <param name="nombreTabla">Nombre que sera asignado a la tabla (maximo 150 caracteres)</param>
        /// <param name="campo1"> Nombre del campo 1(maximo 150 caracteres) y del tipo de dato</param>
        /// <param name="campo2"> Nombre del campo 1(maximo 150 caracteres) y del tipo de dato</param>
        /// <param name="campo3"> Nombre del campo 1(maximo 150 caracteres) y del tipo de dato</param>
        /// <returns>
        /// True si el metodo se ejecuta sin errores, false en caso contrario
        /// </returns>
        /// <example>
        /// El metodo debe ser invocado de la siguiente manera:
        /// <code>
        /// objeto.crearTabla(tblTest, prueba1 int, prueba2 varchar(100), prueba3 date);
        /// </code>
        /// </example>
        public bool crearTabla(string nombreTabla,string campo1,string campo2,string campo3)
        {
            try
            {
                instruccionSQL = new SqlCommand("sp_crearTabla",objConexion);
                instruccionSQL.CommandType = CommandType.StoredProcedure;
                instruccionSQL.Parameters.AddWithValue("@nombreTabla", nombreTabla);
                instruccionSQL.Parameters.AddWithValue("@campo1", campo1);
                instruccionSQL.Parameters.AddWithValue("@campo2", campo2);
                instruccionSQL.Parameters.AddWithValue("@campo3", campo3);
                objConexion.Open();
                instruccionSQL.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                objConexion.Close();
            }
        }


        public bool eliminarTabla(string nombreTabla)
        {
            try
            {
                instruccionSQL=new SqlCommand("sp_eliminarTabla", objConexion);
                instruccionSQL.CommandType = CommandType.StoredProcedure;
                instruccionSQL.Parameters.AddWithValue("@nombreTabla", nombreTabla);
                objConexion.Open();
                instruccionSQL.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                objConexion.Close();
            }
        }
    }
}
