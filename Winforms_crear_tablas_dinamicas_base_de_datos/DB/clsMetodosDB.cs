using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Winforms_crear_tablas_dinamicas_base_de_datos.DB
{

    class clsMetodosDB
    {

        SqlConnection objConexion = new SqlConnection(ClsConexion.getConnectionString);
        SqlCommand instruccionSQL;

        SqlDataReader dr;

        public bool crearTabla(string nombreTabla, string campo1, string campo2, string campo3)
        {
            try
            {
                instruccionSQL = new SqlCommand("sp_crearTabla", objConexion);
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
                instruccionSQL = new SqlCommand("sp_eliminarTabla", objConexion);
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

        public List<clsInformacionTablas> listadoTablas()
        {
            try
            {
                instruccionSQL = new SqlCommand("sp_nombreTablas", objConexion);
                instruccionSQL.CommandType = CommandType.StoredProcedure;
                objConexion.Open();
                dr = instruccionSQL.ExecuteReader();
                List<clsInformacionTablas> lista = new List<clsInformacionTablas>();
                while (dr.Read())
                {
                    lista.Add(new clsInformacionTablas()
                    {
                        Nombre = dr[0].ToString(),
                        id = Convert.ToInt32(dr[1].ToString())
                    });
                }
                return lista;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                objConexion.Close();
            }
        }

        public List<clsCampo> listadoCampos(string nombreTabla)
        {
            try
            {
                instruccionSQL = new SqlCommand("sp_infoTablas", objConexion);
                instruccionSQL.CommandType = CommandType.StoredProcedure;
                instruccionSQL.Parameters.AddWithValue("@nombreTabla", nombreTabla);
                objConexion.Open();
                dr = instruccionSQL.ExecuteReader();
                List<clsCampo> listaCampos = new List<clsCampo>();
                while (dr.Read())
                {
                    listaCampos.Add(
                        new clsCampo
                        {
                            NombreCampo = dr[1].ToString(),
                            TipoDato = dr[2].ToString().ToUpper()
                        });
                }
                return listaCampos;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                objConexion.Close();
            }
        }

        public void modificarCampos(string nombreTabla, string campo,string tipoDato)
        {
            try
            {
                rograa
                instruccionSQL = new SqlCommand("alter table " + nombreTabla + " alter column " + campo + " " + tipoDato,objConexion);
                objConexion.Open();
                instruccionSQL.ExecuteNonQuery();
            }
            finally
            {
                objConexion.Close();
            }
        }

        public void eliminarCampo(string nombreTabla, string campo)
        {
            try
            {
                instruccionSQL = new SqlCommand("alter table " + nombreTabla + " drop column " + campo, objConexion);
                objConexion.Open();
                instruccionSQL.ExecuteNonQuery();
            }
            finally
            {
                objConexion.Close();
            }
        }
    }
}
