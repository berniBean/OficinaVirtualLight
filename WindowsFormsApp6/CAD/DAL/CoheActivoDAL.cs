using MySql.Data.MySqlClient;
using System;
using WindowsFormsApp6.CAD.BO;
using System.Data;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6.CAD.DAL
{

    public class CoheActivoDAL : obtenerOHE
    {
        private readonly string strConn;
        private readonly Login lg = new Login();
        

        public CoheActivoDAL() {
            strConn = System.Configuration.ConfigurationManager.AppSettings["K1"];
        }

        public CoheActivoDAL(string conn) {
                strConn = conn;
        }

        public ListCoheActiva GetOHE(string idSup, string periodo) {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("selectOHEActivo", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    
                    OrdenSql.Parameters.AddWithValue("@idSup", idSup);
                    if (periodo == "")
                        periodo = "0";
                    OrdenSql.Parameters.AddWithValue("@perido", periodo);
                    //Crear conexion para todos los datos
                    ListCoheActiva listOHE = new ListCoheActiva();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        CoheActivaBO fila = new CoheActivaBO(
                            (string)lector["ohe"]);
                        listOHE.Add(fila);
                    }

                    return listOHE;

                }
            }
            catch (MySqlException e)
            {
                throw new ApplicationException("Error " + e);
            }
        }

        public override ListCoheActiva listadosOHE(string idSup, string periodo)
        {
            return GetOHE(idSup, periodo);
        }
    }
}
