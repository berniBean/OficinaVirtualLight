using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public class CCTableroJefeRCODAL
    {
        private readonly string strConn;

        public CCTableroJefeRCODAL()
        {
            strConn = ConfigurationManager.AppSettings["k1"];
        }

        public CCTableroJefeRCODAL(string conn)
        {
            strConn = conn;
        }

        public ListaTableroJefeRCO GetTableroJefeRCO_RIF(int supervisor)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("tableroJefePLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_supervisor", supervisor);
                    ListaTableroJefeRCO listTablero = new ListaTableroJefeRCO();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {
                        CatableroJefeRCO fila = new CatableroJefeRCO(
                                Convert.ToInt16(lector["idEmision"] is DBNull ? null : lector["idEmision"]),
                                Convert.ToString(lector["referenciaNumerica"] is DBNull ? null : lector["referenciaNumerica"]),
                                Convert.ToInt16(lector["anho"] is DBNull ? null : lector["anho"]),
                                Convert.ToString(lector["detalleEmision"] is DBNull ? null : lector["detalleEmision"])
                            );
                        listTablero.Add(fila);

                    }
                    return listTablero;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
