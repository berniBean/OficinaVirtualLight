using MySql.Data.MySqlClient;
using System;
using WindowsFormsApp6.CAD.BO;
using System.Data;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6.CAD.DAL
{

    public class CoheActivoDALPLUS : obtenerOHE
    {
        private readonly string strConn;
        private readonly Login lg = new Login();
        

        public CoheActivoDALPLUS() {
            strConn = System.Configuration.ConfigurationManager.AppSettings["K1"];
        }

        public CoheActivoDALPLUS(string conn) {
                strConn = conn;
        }

        public ListCoheActiva GetOHENotificadores(string idSup)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("GetListadoOHENotificadores", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    OrdenSql.Parameters.AddWithValue("@idSup", idSup);
                    //Crear conexion para todos los datos
                    ListCoheActiva listOHE = new ListCoheActiva();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        CoheActivaBO fila = new CoheActivaBO()
                        {
                            IdclaveOHE = (int)lector["idclaveOHE"],
                            OHE = (string)lector["ohe"]
                        };
                        
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

        public ListCoheActiva GetOHE(string idSup, string periodo) {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("selectOHEActivoPLUS", conn)
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

        public override ListCoheActiva ListadoNotificadoresOHE(string idSup)
        {
            return GetOHENotificadores(idSup);
        }
    }
}
