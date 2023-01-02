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
    public class CCBusquedaRIFDAL : obtenerBusqueda
    {
        private readonly string strConn;

        public CCBusquedaRIFDAL()
        {
            strConn = System.Configuration.ConfigurationManager.AppSettings["K1"];
        }

        public CCBusquedaRIFDAL(string conn)
        {
            strConn = conn;
        }


        public ListaCBusquedaRIF GetListaBusquedaRIF(string dato)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("busquedaRIF", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_datoBusqueda", dato);

                    ListaCBusquedaRIF listMultas = new ListaCBusquedaRIF();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {
                        CBusquedaRIFBO fila = new CBusquedaRIFBO(
                            Convert.ToInt32(lector["ordenarPor"]),
                            Convert.ToString(lector["emision"]),
                            Convert.ToInt32(lector["numReq"]),
                            Convert.ToString(lector["numCtrl"]),
                            Convert.ToString(lector["zona"]),
                            Convert.ToString(lector["municipio"]),
                            Convert.ToString(lector["RFC"]),
                            Convert.ToString(lector["razonSocial"]),
                            lector["diligenica"] is DBNull ? "" : ((Int32)lector["diligenica"] == 2 ? "NO TRABAJADO" : ((Int32)lector["diligenica"] == 0 ? "NO LOCALIZADO" : "LOCALIZADO")),//_diligencia
                            Convert.ToDateTime(lector["fechaCitatorio"] is DBNull ? null : lector["fechaCitatorio"]),//_fechaCitatorio
                            Convert.ToDateTime(lector["fechaNotificacion"] is DBNull ? null : lector["fechaNotificacion"])//_fechaNotificacion
                            );
                        listMultas.Add(fila);
                    }
                    return listMultas;
                }
            }
            catch (MySqlException e)
            {

                throw new ApplicationException("Error " + e);
            }
        }

        public override ListaCBusquedaRIF ListaBusqueda(string dato)
        {
            return GetListaBusquedaRIF(dato);
        }
    }
}
