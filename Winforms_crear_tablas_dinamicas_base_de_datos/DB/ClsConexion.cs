using System.Configuration;

namespace Winforms_crear_tablas_dinamicas_base_de_datos.DB
{
    /// <summary>
    /// Clase encargada de obtener la cadena de conexion
    /// </summary>
    public abstract class ClsConexion
    {
        /// <summary>
        /// Variable de clase estatica que almacena la cadena de conexion.
        /// </summary>
        public static string getConnectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;

    }
}
