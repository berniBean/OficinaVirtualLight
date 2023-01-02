using MySql.Data.MySqlClient;
using System.Data;
using System;
using WindowsFormsApp6.BO;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6.DAL
{
    class CanhoFiscalDALPLUS : obtenerPeriodoFiscal
    {
        private readonly string strConn;

        public CanhoFiscalDALPLUS() {
            strConn = System.Configuration.ConfigurationManager.AppSettings["k1"];
        }

        public CanhoFiscalDALPLUS(string conn) {
            strConn = conn;
        }

        public ListCanhoFiscal GetAnho() {
            try {
                using (MySqlConnection conn = new MySqlConnection(strConn)) {
                    MySqlCommand OrdenSql = new MySqlCommand("selectYearPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    //Crear conexion para todos los datos
                    ListCanhoFiscal listAnho = new ListCanhoFiscal();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read()) {

                        CanhoFiscalBO fila = new CanhoFiscalBO(
                            (int)lector["anho"]);
                        listAnho.Add(fila);
                    }

                    return listAnho;

                }
            } catch (MySqlException e) {
                throw new ApplicationException("Error " + e);
            }
        }

        public override ListCanhoFiscal listadoAños()
        {
            return GetAnho();
        }
    }
}
