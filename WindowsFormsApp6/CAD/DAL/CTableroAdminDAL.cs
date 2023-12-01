using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using WindowsFormsApp6.CAD.BO;
using MySql.Data.MySqlClient;
using System.Data;
using WindowsFormsApp6.CAD.DAL.factories;
using System.Windows.Forms;

namespace WindowsFormsApp6.CAD.DAL
{
    class CTableroAdminDAL : obtenerTableroSup
    {
        private readonly string strConn;

        public CTableroAdminDAL() 
        {
            strConn = ConfigurationManager.AppSettings["k1"];
        }

        public CTableroAdminDAL(string conn)
        {
            strConn = conn;
        }

        private async Task<CListaTableroAdmin> EjerciciosFisales()
        {
            try {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("ejerciciosMultaTotalRIFxPDF", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    CListaTableroAdmin contDatosEmisiones = new CListaTableroAdmin();
                    conn.Open();
                    MySqlDataReader lector = (MySqlDataReader)await OrdenSql.ExecuteReaderAsync();

                    while (await lector.ReadAsync())
                    {
                        CTableroAdminBO fila = new CTableroAdminBO(
                                Convert.ToInt16(lector["ejercicio"] is DBNull ? null : lector["ejercicio"])
                            );
                        contDatosEmisiones.Add(fila);
                    }
                    return contDatosEmisiones;
                }
            } catch (MySqlException ex) {
                throw new ApplicationException("Error " + ex);
            }
        }

        public CListaTableroAdmin GetTableroMultasSupervisor(int supervisor, int ejercicio) 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("tablaMultasRIFPendienteEmisionXPdf", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_supervisor", supervisor);
                    OrdenSql.Parameters.AddWithValue("@_ejercicio", ejercicio);
                    CListaTableroAdmin listTablero = new CListaTableroAdmin();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {
                        CTableroAdminBO fila = new CTableroAdminBO(
                                Convert.ToInt16(lector["ejercicio"] is DBNull ? null : lector["ejercicio"]),
                                Convert.ToInt16(lector["emision"] is DBNull ? null : lector["emision"]),
                                Convert.ToDateTime(lector["fechaEmision"] is DBNull ? null : lector["fechaEmision"]),
                                Convert.ToInt16(lector["extp"] is DBNull ? null : lector["extp"]),
                                Convert.ToInt16(lector["incp"] is DBNull ? null : lector["incp"]),
                                Convert.ToInt16(lector["emitido"] is DBNull ? null : lector["emitido"]),
                                Convert.ToInt16(lector["enviados"] is DBNull ? null : lector["enviados"]),
                                Convert.ToInt16(lector["pendiente"] is DBNull ? null : lector["pendiente"]),
                                Convert.ToInt16(lector["vencidos"] is DBNull ? null : lector["vencidos"]),
                                Convert.ToInt16(lector["cobrados"] is DBNull ? null : lector["cobrados"]),
                                Convert.ToInt32(lector["total"] is DBNull ? null : lector["total"]),
                                Convert.ToInt32(lector["honorarios"] is DBNull ? null : lector["honorarios"]),
                                Convert.ToString(lector["NombreMultaRIF"] is DBNull ? null : lector["NombreMultaRIF"]),
                                Convert.ToString(lector["OrigenMultaRIF"] is DBNull ? null : lector["OrigenMultaRIF"]),
                                Convert.ToInt32(lector["pendientePDF"] is DBNull ? null : lector["pendientePDF"])

                            );
                        listTablero.Add(fila);

                    }
                    return listTablero;
                }
            }
            catch (MySqlException ex)
            {

                throw new ApplicationException("Error " + ex);
            }
        }
        public async Task<CListaTableroAdmin> GetTablero(int año) 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn)) 
                {
                    MySqlCommand OrdenSql = new MySqlCommand("tableroJefeRIF", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_ahno", año);
                    CListaTableroAdmin listTablero = new CListaTableroAdmin();
                    conn.Open();
                    MySqlDataReader lector = (MySqlDataReader)await OrdenSql.ExecuteReaderAsync();

                    while (await lector.ReadAsync()) 
                    {
                        CTableroAdminBO fila = new CTableroAdminBO(
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
            catch (MySqlException ex)
            {

                throw new ApplicationException("Error " + ex);
            }
        }

        private CListaTableroAdmin GetTableroEjercicioFiscal()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("TableroEjercicioRIF", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    CListaTableroAdmin listTablero = new CListaTableroAdmin();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {
                        CTableroAdminBO fila = new CTableroAdminBO(
                            Convert.ToInt16(lector["_Efiscal"] is DBNull ? null : lector["_Efiscal"])
                            );
                        listTablero.Add(fila);

                    }
                    return listTablero;
                }
            }
            catch (MySqlException ex)
            {

                throw new ApplicationException("Error " + ex);
            }
        }
        private CListaTableroAdmin GetAvanceGeneralEmision(int emision, int idSup)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("avanceEmisionGeneral", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_emision", emision);
                    OrdenSql.Parameters.AddWithValue("@_IdSup", idSup);
                    CListaTableroAdmin listTablero = new CListaTableroAdmin();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {
                        CTableroAdminBO fila = new CTableroAdminBO(
                            Convert.ToString(lector["zona"] is DBNull ? null : lector["zona"]),
                            Convert.ToString(lector["OHE"] is DBNull ? null : lector["OHE"]),
                            Convert.ToInt16(lector["Total"] is DBNull ? null : lector["total"]),
                            Convert.ToInt16(lector["pendientes"] is DBNull ? null : lector["pendientes"]),
                            Convert.ToInt16(lector["Localizado"] is DBNull ? null : lector["Localizado"]),
                            Convert.ToInt16(lector["Nolocalizado"] is DBNull ? null : lector["Nolocalizado"]),
                            Convert.ToInt16(lector["NoTrabajado"] is DBNull ? null : lector["NoTrabajado"]),
                            Convert.ToInt16(lector["porcentajeFalla"] is DBNull ? null : lector["porcentajeFalla"]),
                            Convert.ToInt16(lector["pndPDF"] is DBNull ? null : lector["pndPDF"])
                            );
                        listTablero.Add(fila);

                    }
                    return listTablero;
                }
            }
            catch (MySqlException ex)
            {

                throw new ApplicationException("Error " + ex);
            }
        }


        private async Task<CListaTableroAdmin> GetListadoRequeridos(int emision, int idSup)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("listadoCompletoJefeRIF", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_idEmision", emision);
                    OrdenSql.Parameters.AddWithValue("@_idSup", idSup);
                    CListaTableroAdmin listTablero = new CListaTableroAdmin();
                    conn.Open();
                    MySqlDataReader lector = (MySqlDataReader)await OrdenSql.ExecuteReaderAsync();

                    while (await lector.ReadAsync())
                    {
                        CTableroAdminBO fila = new CTableroAdminBO(
                            Convert.ToString(lector["zona"] is DBNull ? null : lector["zona"]),
                            Convert.ToString(lector["OHE"] is DBNull ? null : lector["OHE"]),
                            Convert.ToString(lector["municipio"] is DBNull ? null : lector["municipio"]),
                            Convert.ToInt16(lector["numReq"] is DBNull ? null : lector["numReq"]),
                            Convert.ToString(lector["RFC"] is DBNull ? null : lector["RFC"]),                            
                            Convert.ToString(lector["NumCtrl"] is DBNull ? null : lector["NumCtrl"]),
                            Convert.ToString(lector["rs"] is DBNull ? null : lector["rs"]),
                            lector["diligenica"] is DBNull ? "" : ((Int32)lector["diligenica"] == 2 ? "NO TRABAJADO" : ((Int32)lector["diligenica"] == 0 ? "NO LOCALIZADO" : "LOCALIZADO")),//_diligencia
                            Convert.ToDateTime(lector["notificacion"] is DBNull ? null : lector["notificacion"]),
                            Convert.ToDateTime(lector["citatorio"] is DBNull ? null : lector["citatorio"]),
                            Convert.ToString(lector["estatus"] is DBNull ? null : lector["estatus"]),
                            Convert.ToString(lector["PDF"] is DBNull ? null : lector["PDF"])


                            );
                        listTablero.Add(fila);

                    }
                    return listTablero;
                }
            }
            catch (MySqlException ex)
            {

                throw new ApplicationException("Error " + ex);
            }
        }

        private async Task<CListaTableroAdmin> GetListadoMultasRIFAdmin(int año)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {

                    MySqlCommand OrdenSql = new MySqlCommand("tableroMultasRIFAdmin", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_ejercicio", año);
                    CListaTableroAdmin listTablero = new CListaTableroAdmin();
                    conn.Open();
                    MySqlDataReader lector = (MySqlDataReader)await OrdenSql.ExecuteReaderAsync();

                    while (await lector.ReadAsync())
                    {
                        CTableroAdminBO fila = new CTableroAdminBO(
                            Convert.ToInt16(lector["emision"] is DBNull ? null : lector["emision"]),
                               Convert.ToString(lector["nombreEmision"] is DBNull ? null : lector["nombreEmision"]),
                               Convert.ToDateTime(lector["fechaEmision"] is DBNull ? null : lector["fechaEmision"]),
                                Convert.ToInt16(lector["ejercicio"] is DBNull ? null : lector["ejercicio"]),
                                Convert.ToString(lector["clave_Oficio"] is DBNull ? null : lector["clave_Oficio"])
                            );

                        listTablero.Add(fila);

                    }
                    return listTablero;
                }
            }
            catch (MySqlException ex)
            {

                throw new ApplicationException("Error " + ex);
            }
        }

        private async Task<CListaTableroAdmin> GetAvanceMultasRIF(int idEmision, int idSup)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("avanceGeneralRIFAdmin", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_idEmision", idEmision);
                    OrdenSql.Parameters.AddWithValue("@_idSup", idSup);
                    CListaTableroAdmin listTablero = new CListaTableroAdmin();
                    conn.Open();
                    MySqlDataReader lector = (MySqlDataReader)await OrdenSql.ExecuteReaderAsync();

                    while (await lector.ReadAsync())
                    {
                        CTableroAdminBO fila = new CTableroAdminBO(
                            Convert.ToString(lector["zona"] is DBNull ? null : lector["zona"]),
                            Convert.ToString(lector["OHE"] is DBNull ? null : lector["OHE"]),
                            Convert.ToInt16(lector["emitido"] is DBNull ? null : lector["emitido"]),
                            Convert.ToInt16(lector["extp"] is DBNull ? null : lector["extp"]),
                            Convert.ToInt16(lector["incp"] is DBNull ? null : lector["incp"]),
                            Convert.ToInt16(lector["pendiente"] is DBNull ? null : lector["pendiente"]),
                            Convert.ToInt16(lector["Localizado"] is DBNull ? null : lector["Localizado"]),
                            Convert.ToInt16(lector["Nolocalizado"] is DBNull ? null : lector["Nolocalizado"]),
                            Convert.ToInt16(lector["NoTrabajado"] is DBNull ? null : lector["NoTrabajado"]),
                            Convert.ToInt16(lector["pendientePDF"] is DBNull ? null : lector["pendientePDF"]),
                            Convert.ToInt16(lector["vencidos"] is DBNull ? null : lector["vencidos"]),
                            Convert.ToInt16(lector["cobrados"] is DBNull ? null : lector["cobrados"]),
                            Convert.ToInt32(lector["honorarios"] is DBNull ? null : lector["honorarios"]),
                            Convert.ToInt32(lector["total"] is DBNull ? null : lector["total"])
                            );
                        listTablero.Add(fila);

                    }
                    return listTablero;
                }
            }
            catch (MySqlException ex)
            {

                throw new ApplicationException("Error " + ex);
            }
        }


        private async Task<ListaClistaRequeridos> GetMultasGenAdminRIF(int idEmision, int idSup)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("tableroMultasGenRIFAdmin", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    OrdenSql.Parameters.AddWithValue("@_idEmision", idEmision);
                    OrdenSql.Parameters.AddWithValue("@_idSup", idSup);
                    //Crear conexion para todos los datos
                    ListaClistaRequeridos listOHE = new ListaClistaRequeridos();
                    conn.Open();
                    MySqlDataReader lector = (MySqlDataReader)await OrdenSql.ExecuteReaderAsync();

                    while (await lector.ReadAsync())
                    {

                        CListaRequeridosBO fila = new CListaRequeridosBO(
                            Convert.ToString(lector["zona"]),
                            Convert.ToString(lector["OHE"]),
                            Convert.ToString(lector["idMultaRIF"]),
                            (string)lector["TIPO_MULTA"],
                            Convert.ToInt16(lector["CTRL_MULTA"] is DBNull ? null : lector["CTRL_MULTA"]),
                            (string)lector["rfc"],                            
                            (string)lector["NUM_CTRL_REQUERIMIENTO"],
                            (string)lector["razonSocial"],
                            (string)lector["detalleEmision"],
                            Convert.ToInt16(lector["numReq"]),
                            lector["diligencia"] is DBNull ? "" : ((Int32)lector["diligencia"] == 2 ? "NO TRABAJADO" : ((Int32)lector["diligencia"] == 0 ? "NO LOCALIZADO" : "LOCALIZADO")),//_diligencia
                            Convert.ToDateTime(lector["fechaCitatorio"] is DBNull ? null : lector["fechaCitatorio"]),//__fechaCitatorio
                            Convert.ToDateTime(lector["fechaNotificacion"] is DBNull ? null : lector["fechaNotificacion"]),//__fechaCitatorio
                            Convert.ToDateTime(lector["fechapago"] is DBNull ? null : lector["fechapago"]),//__fechaCitatorio
                            Convert.ToDouble(lector["importe"] is DBNull ? null : lector["importe"]),
                            Convert.ToDouble(lector["honorarios"] is DBNull ? null : lector["honorarios"]),
                            Convert.ToBoolean(lector["cumplioantes"] is DBNull ? null : lector["cumplioantes"]),
                            Convert.ToDateTime(lector["fechaVencimiento"] is DBNull ? null : lector["fechaVencimiento"]),
                            Convert.ToString(lector["observaciones"] is DBNull ? null : lector["observaciones"]),
                            Convert.ToString(lector["ejecucion"] is DBNull ? null : lector["ejecucion"]),
                            Convert.ToString(lector["estatus"] is DBNull ? null : lector["estatus"]),
                            Convert.ToString(lector["estatusPDF"] is DBNull ? null : lector["estatusPDF"])
                            );
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

        public override async Task<CListaTableroAdmin> TableroMultasSupervisor(int supervisor, int ejercicio)
        {
            throw new NotImplementedException();
        }

        public override async Task<CListaTableroAdmin> Tablero(int año)
        {
            return await GetTablero(año);
        }


        public override CListaTableroAdmin GetVanceEmision(int emision, int idSup)
        {
            return GetAvanceGeneralEmision(emision, idSup);
        }

        public override async Task<CListaTableroAdmin> GetListadoCompleto(int emision, int idSup)
        {
            return await GetListadoRequeridos(emision, idSup);
        }

        public override CListaTableroAdmin TableroEjercicioFiscal()
        {
            return GetTableroEjercicioFiscal();
        }

        public override async Task< CListaTableroAdmin> GetEjerciciosFisales()
        {
            return await EjerciciosFisales();
        }

        public override async Task<CListaTableroAdmin> TableroMultasAdmin(int año)
        {
            return await GetListadoMultasRIFAdmin(año);
        }

        public override async Task<CListaTableroAdmin> GetAvanceMultasAdmin(int emision, int idSup)
        {
            return await GetAvanceMultasRIF(emision, idSup);
        }

        public override async Task<ListaClistaRequeridos> GetTableroMultasGENAdmin(int emision, int idSup)
        {
            return await GetMultasGenAdminRIF(emision, idSup);
        }

        public override Task<CListaTableroAdmin> GetEjerciciosMultasFisales()
        {
            throw new NotImplementedException();
        }

        public override Task<CListaTableroAdmin> TableroPLUS(int año)
        {
            throw new NotImplementedException();
        }
    }
}
