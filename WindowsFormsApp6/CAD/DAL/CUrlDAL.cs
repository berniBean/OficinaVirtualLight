using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6.CAD.DAL
{
    class CUrlDAL : obtenerURL
    {
        private readonly string strConn;
        private int _tipo;

        public CUrlDAL(int tipo)
        {
            strConn = System.Configuration.ConfigurationManager.AppSettings["k1"];
            _tipo = tipo;
        }

        public CUrlDAL(string conn)
        {
            strConn = conn;
        }

        public CListaURL GetCUrls()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("selectURL", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_tipo", _tipo);
                    //Crear conexion para todos los datos
                    CListaURL listURL = new CListaURL();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        CUrlBO fila = new CUrlBO(
                            (string)lector["url"]);
                        listURL.Add(fila);
                    }

                    return listURL;
                }

            }

            catch (Exception)
            {

                throw;
            }
        }

        public override CListaURL listaURI()
        {
           return  GetCUrls();
        }
    }
}
