using System.Data;
using System;
using MySql.Data.MySqlClient;
using WindowsFormsApp6.CAD.BO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.DAL
{
    class CDiaFeriadoDAL
    {
        private readonly string strConn;

        public CDiaFeriadoDAL()
        {
            strConn = System.Configuration.ConfigurationManager.AppSettings["k1"];
        }

        public CDiaFeriadoDAL(string conn)
        {
            strConn = conn;
        }

        public  async Task< List<CdiasFeriadosBO>> GetDiasFestivos()
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
                    List<CdiasFeriadosBO> listFeriados = new List<CdiasFeriadosBO>();
                    conn.Open();
                    MySqlDataReader lector = (MySqlDataReader) await OrdenSql.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                    while ( await lector.ReadAsync())
                    {

                        CdiasFeriadosBO fila = new CdiasFeriadosBO(
                            Convert.ToDateTime(lector["dia"]));
                        listFeriados.Add(fila);
                    }

                    return listFeriados;

                }
            }
            catch (MySqlException e)
            {
                throw new ApplicationException("Error " + e);
            }
        }
        
    }
}
