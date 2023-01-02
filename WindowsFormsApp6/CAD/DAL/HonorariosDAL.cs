using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.BO;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.CAD.DAL
{
    class HonorariosDAL
    {
        private readonly string strConn;

        public HonorariosDAL()
        {
            strConn = System.Configuration.ConfigurationManager.AppSettings["k1"];
        }

        public HonorariosDAL(string conn)
        {
            strConn = conn;
        }

        public ListaHonorarios getHonorarios(int emision)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("getHonorarios", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_Emision", emision);
                    //Crear conexion para todos los datos
                    ListaHonorarios listHonorarios= new ListaHonorarios();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        honorarios fila = new honorarios(
                            Convert.ToDouble(lector["honorarios"] is DBNull ? null : lector["honorarios"]));
                        listHonorarios.Add(fila);
                    }

                    return listHonorarios;

                }
            }
            catch (MySqlException e)
            {
                throw new ApplicationException("Error " + e);
            }
        }
    }
}
