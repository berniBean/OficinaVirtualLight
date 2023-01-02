using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6.CAD.DAL
{
    public class CCBusquedaMultasDALPLUS : obtenerBusquedaMultas
    {
        private readonly string strConn;

        public CCBusquedaMultasDALPLUS()
        {
            strConn = System.Configuration.ConfigurationManager.AppSettings["K1"];
        }

        public CCBusquedaMultasDALPLUS(string conn)
        {
            strConn = conn;
        }

        public override ListaCBusquedaMultas busquedaMultas(string dato)
        {
            return GetListaBusquedaMultasRIF(dato);
        }

        public ListaCBusquedaMultas GetListaBusquedaMultasRIF(string dato)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("busquedaMultasGenPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_datoBusqueda", dato);

                    ListaCBusquedaMultas listMultas = new ListaCBusquedaMultas();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {
                        CBusquedaMultasBO fila = new CBusquedaMultasBO(
                            Convert.ToString(lector["_emision"]),
                            Convert.ToInt32(lector["_emisionMulta"]),
                            Convert.ToInt32(lector["_numReq"]),
                            Convert.ToString(lector["_zona"]),
                            Convert.ToString(lector["_municipio"]),
                            Convert.ToString(lector["_tipoMulta"]),
                            Convert.ToString(lector["_ctrlMulta"]),
                            Convert.ToDateTime(lector["_fechaEmision"] is DBNull? null : lector["_fechaEmision"]),
                            Convert.ToString(lector["_RFC"]),
                            Convert.ToString(lector["_numCtrl"]),
                            Convert.ToString(lector["_razonSocial"]),
                            lector["_diligencia"] is DBNull ? "" : ((Int32)lector["_diligencia"] == 2 ? "NO TRABAJADO" : ((Int32)lector["_diligencia"] == 0 ? "NO LOCALIZADO" : "LOCALIZADO")),//_diligencia
                            Convert.ToDateTime(lector["_notificacion"] is DBNull ? null : lector["_notificacion"]),//_fechaCitatorio
                            Convert.ToDateTime(lector["_fechaPago"] is DBNull ? null : lector["_fechaPago"]),//_fechaCitatorio                            
                            Convert.ToDouble(lector["_honorarios"] is DBNull ? null : lector["_honorarios"]),
                            Convert.ToDouble(lector["_importe"] is DBNull ? null : lector["_importe"]),
                            Convert.ToDateTime(lector["_vencimiento"] is DBNull ? null : lector["_vencimiento"]),//_fechaCitatorio                            
                            Convert.ToString(lector["_ejecucion"])
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
    }
}
