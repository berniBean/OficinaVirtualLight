using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public class OficiosDALRIF : obtenerOficiosSQL
    {
        private readonly string strConn;
        public OficiosDALRIF()
        {
            strConn = System.Configuration.ConfigurationManager.AppSettings["k1"];
        }

        private async Task<ListCOficios> ConcentradoOficiosMULTASRIF(string nombreEmision, int idEmision, int idSup) 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("reporteOficiosMultasRIF", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    OrdenSql.Parameters.AddWithValue("@_nombreEmision", nombreEmision);
                    OrdenSql.Parameters.AddWithValue("@_IdEmision", idEmision);
                    OrdenSql.Parameters.AddWithValue("@_idSup", idSup);
                    //Crear conexion para todos los datos
                    ListCOficios listOficios = new ListCOficios();
                    await conn.OpenAsync();
                    MySqlDataReader lector = (MySqlDataReader)await OrdenSql.ExecuteReaderAsync();

                    while (await lector.ReadAsync())
                    {
                        COficiosBO fila = new COficiosBO(
                            Convert.ToInt32(lector["idOficio"]),
                            (string)lector["referenciaNumerica"],
                            (string)lector["zona"],
                            (string)lector["OHE"],
                            Convert.ToDateTime(lector["fechaEmision"] is DBNull ? null : lector["fechaEmision"]),
                            Convert.ToInt32(lector["NumOficio"] is DBNull ? null : lector["NumOficio"]),
                            Convert.ToDateTime(lector["fechaOficios"] is DBNull ? null : lector["fechaOficios"]),
                            Convert.ToDateTime(lector["FechaRetro"] is DBNull ? null : lector["FechaRetro"]),
                            (string)lector["Genero"],
                            (string)lector["JEFE"],
                            (string)lector["DOMICILIO"],
                            (string)lector["cp"],
                            Convert.ToInt32(lector["totalMultas"] is DBNull ? null : lector["totalMultas"]),
                            Convert.ToInt32(lector["totalMERIF"] is DBNull ? null : lector["totalMERIF"]),
                            Convert.ToInt32(lector["INICIOME"] is DBNull ? null : lector["INICIOME"]),
                            Convert.ToInt32(lector["FINALME"] is DBNull ? null : lector["FINALME"]),
                            Convert.ToInt32(lector["totalMIRIF"] is DBNull ? null : lector["totalMIRIF"]),
                            Convert.ToInt32(lector["INICIOMI"] is DBNull ? null : lector["INICIOMI"]),
                            Convert.ToInt32(lector["FINALMI"] is DBNull ? null : lector["FINALMI"])

                            );

                        listOficios.Add(fila);
                    }

                    return listOficios;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task<ListCOficios> ConcentradoOficiosRIF(string nombreEmision, int idEmision, string idSup)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("reporteOficiosRIF", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    OrdenSql.Parameters.AddWithValue("@_nombreEmision", nombreEmision);
                    OrdenSql.Parameters.AddWithValue("@_IdEmision", idEmision);
                    OrdenSql.Parameters.AddWithValue("@_idSup", idSup);
                    //Crear conexion para todos los datos
                    ListCOficios listOficios = new ListCOficios();
                    await conn.OpenAsync();
                    MySqlDataReader lector = (MySqlDataReader)await OrdenSql.ExecuteReaderAsync();

                    while (await lector.ReadAsync())
                    {
                        //lector["fechaCitatorio"] is DBNull ? null : lector["fechaCitatorio"]
                        COficiosBO fila = new COficiosBO(
                            Convert.ToInt32(lector["idOficio"]),
                            (string)lector["referenciaNumerica"],
                            (string)lector["zona"],
                            (string)lector["OHE"],
                            Convert.ToDateTime(lector["fechaImpresion"] is DBNull ? null : lector["fechaImpresion"]),
                            Convert.ToInt32(lector["NumOficio"] is DBNull ? null : lector["NumOficio"]),
                            Convert.ToDateTime(lector["fechaOficios"] is DBNull ? null : lector["fechaOficios"]),
                            Convert.ToDateTime(lector["FechaRetro"] is DBNull ? null : lector["FechaRetro"]),
                            (string)lector["Genero"],
                            (string)lector["JEFE"],
                            (string)lector["DOMICILIO"],
                            (string)lector["cp"],
                            Convert.ToInt32(lector["total"]),
                            Convert.ToInt32(lector["folioInicio"]),
                            Convert.ToInt32(lector["folioFinal"]));

                        listOficios.Add(fila);
                    }

                    return listOficios;

                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private async Task<ListCOficios> OficiosRIF(string idEmision)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("OficiosSQLPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    OrdenSql.Parameters.AddWithValue("@_ReferenciaNumerica", idEmision);
                    //Crear conexion para todos los datos
                    ListCOficios listOficios = new ListCOficios();
                    await conn.OpenAsync();
                    MySqlDataReader lector = (MySqlDataReader)await OrdenSql.ExecuteReaderAsync();

                    while (await lector.ReadAsync())
                    {
                        //lector["fechaCitatorio"] is DBNull ? null : lector["fechaCitatorio"]
                        COficiosBO fila = new COficiosBO(
                            Convert.ToInt32(lector["idOficio"]),
                            (string)lector["referenciaNumerica"],
                            (string)lector["zona"],
                            (string)lector["OHE"],
                            Convert.ToInt32(lector["NumOficio"] is DBNull ? null : lector["NumOficio"]),
                            Convert.ToDateTime(lector["fechaRetro"] is DBNull ? null : lector["fechaRetro"])

                            );

                        listOficios.Add(fila);
                    }

                    return listOficios;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private async Task ModificaOficios(COficiosBO oficios)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("updateOficiosPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Parametros
                    OrdenSql.Parameters.AddWithValue("@_idOficio", oficios.IdOficio);
                    OrdenSql.Parameters.AddWithValue("@_oficioNum", oficios.NumOficio);
                    //Abrir la conexion de base de Datos
                    await conn.OpenAsync();
                    await OrdenSql.ExecuteNonQueryAsync();

                }
            }
            catch (MySqlException err)
            {
                throw new ApplicationException("Error Insert Fechas" + err);
            }
        }
        public override async Task<ListCOficios> listadoConcentradoOficioSql(string nombreEmision, int idEmision, string idSup)
        {
            return await ConcentradoOficiosRIF(nombreEmision, idEmision, idSup);
        }

        public override async Task<ListCOficios> listadoOficiosSql(string idEmision)
        {
            return await OficiosRIF(idEmision);
        }

        public override async Task modificaNumOfico(COficiosBO oficios)
        {
            await ModificaOficios(oficios);
        }

        public override async Task<ListCOficios> listadoConcentradoOficioMultasSql(string nombreEmision, int idEmision, int idSup)
        {
           return  await ConcentradoOficiosMULTASRIF(nombreEmision, idEmision, idSup);
        }
    }
}
