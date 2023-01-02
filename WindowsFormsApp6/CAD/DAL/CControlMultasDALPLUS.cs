using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.CAD.DAL
{
    class CControlMultasDALPLUS
    {
        private readonly string strConn;

        public CControlMultasDALPLUS()
        {
            strConn = System.Configuration.ConfigurationManager.AppSettings["k1"];
        }

        public CControlMultasDALPLUS(string conn)
        {
            strConn = conn;
        }

        public List<CControlMultasBO> GetCControlMultas()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("GetNoLaboral", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    //Crear conexion para todos los datos
                    List<CControlMultasBO> listControlMultas = new List<CControlMultasBO>();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        CControlMultasBO fila = new CControlMultasBO(
                            Convert.ToInt32(lector["emision"]),
                            Convert.ToDateTime(lector["fechaEmision"] is DBNull ? null : lector["fechaEmision"]),
                            Convert.ToInt32(lector["ejercicio"]),
                            Convert.ToString(lector["NombreEmision"]),
                            Convert.ToInt32(lector["honorarios"]),
                            Convert.ToInt32(lector["cantidadMulta"])
                            );
                        listControlMultas.Add(fila);
                    }

                    return listControlMultas;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
