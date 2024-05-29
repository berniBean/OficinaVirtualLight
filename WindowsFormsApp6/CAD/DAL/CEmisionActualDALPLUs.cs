using MySql.Data.MySqlClient;
using System;
using WindowsFormsApp6.CAD.BO;
using System.Data;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.DAL.factories;
using WindowsFormsApp6.BO;

namespace WindowsFormsApp6.CAD.DAL
{
    public class CEmisionActualDALPLUs : obtenerEmision
    {
        private readonly string strConn;

        public CEmisionActualDALPLUs() {
            strConn = System.Configuration.ConfigurationManager.AppSettings["K1"];
        }

        public CEmisionActualDALPLUs(string conn) {
            strConn = conn;
        }

        public ListCEmisionActual  GetPeriodo(string anhoFiscal)    {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("selectEmisionPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (anhoFiscal == "")
                        anhoFiscal = "2018";
                    OrdenSql.Parameters.AddWithValue("@anhoEmision", anhoFiscal);
                    //Crear conexion para todos los datos
                    ListCEmisionActual listPeriodo = new ListCEmisionActual();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {
                        CEmisionActualBO fila = new CEmisionActualBO
                            (
                                (int)lector["idEmision"],
                                (string)lector["detalleEmision"],
                                (DateTime)lector["fechaImpresion"]

                            );
                        listPeriodo.Add(fila);
                    }

                    return listPeriodo;

                }
            }
            catch (MySqlException e)
            {
                throw new ApplicationException();
            }
        }

        public override ListCEmisionActual listadoEmisiones(string año)
        {
            return GetPeriodo(año);
        }
    }
}
