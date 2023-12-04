using MySql.Data.MySqlClient;
using System;
using WindowsFormsApp6.CAD.BO;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApp6.CAD.DAL.factories;
using WindowsFormsApp6.Cache;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Threading;
using WindowsFormsApp6.structs;

namespace WindowsFormsApp6.CAD.DAL
{
    class ClistaRequeridosDALPLUS : obtenerRequeridos
    {
        private readonly string strConn;        
        private readonly ToolStripProgressBar _progressBar;
        private readonly Label _lblProgress;


        CListNotificadores notificador = CUserLoggin.Notificadores;

        public ClistaRequeridosDALPLUS(ToolStripProgressBar progressBar, Label lblProgress) {
            strConn = System.Configuration.ConfigurationManager.AppSettings["K1"];
            _progressBar = progressBar;
            _lblProgress = lblProgress;


        }

        public ClistaRequeridosDALPLUS(string conn) {
            strConn = conn;
        }

        public void ModificaEstatusPDFRequerimientos()
        {

        }
        
        public void ModificaObservacionesMultasRIF(CListaRequeridosBO bo) 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("observacionesMultasPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Parametros
                    OrdenSql.Parameters.AddWithValue("@_numCtrl", bo._idMultaRif);
                    OrdenSql.Parameters.AddWithValue("@_observaciones", bo.Observaciones);
                    //Abrir la conexion de base de Datos
                    conn.Open();
                    OrdenSql.ExecuteNonQuery();

                }
            }
            catch (MySqlException err)
            {
                throw new ApplicationException("Error Insert Fechas" + err);
            }
        }

        public async Task ModificarObservacionesRIF(List<CListaRequeridosBO> bo,IProgress<int> progress = null)
        {
            using var semaforo = new SemaphoreSlim(50);
            var tareas = new List<Task<bool>>();
            var total = bo.Count();


            var i = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();

                    MySqlCommand OrdenSql = new MySqlCommand("UpdateDGRequerimientos", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };


                    
                    await Task.Run(() =>
                    {
                        
                        tareas = bo.Select(async r =>
                        {
                            await semaforo.WaitAsync();
                            try
                            {
                                OrdenSql.Parameters.Clear();

                                i++;

                                OrdenSql.Parameters.AddWithValue("@_numCtrl", r.NumCtrl);
                                OrdenSql.Parameters.AddWithValue("@_observaciones",  r.Observaciones);
                                OrdenSql.Parameters.AddWithValue("@_notasObservaciones", r.NotasObservaciones);
                                OrdenSql.Parameters.AddWithValue("@_actaNotificacion", r.ActaNotificacion);
                                OrdenSql.Parameters.AddWithValue("@_actaCitatorio", r.ActaCitatorio);
                                OrdenSql.Parameters.AddWithValue("@_notificacionCitatorio", r.NotificacionCitatorio);
                                OrdenSql.Parameters.AddWithValue("@_nombreNotificador", VerificaNotificador(r.NombreNotificador));


                                
                                OrdenSql.ExecuteNonQuery();
                                progress.Report(StaticPercentage.PercentageProgress(i, total));

                            }
                            catch (Exception ex)
                            {

                                MessageBox.Show(ex.Message);
                            }

                            return r.Modificado;
                        }).ToList();
                    });
                    await Task.WhenAll(tareas);

                    //Parametros
                    //Abrir la conexion de base de Datos


                }
            }
            catch (MySqlException err)
            {
                throw new ApplicationException("Error Insert Fechas" + err);
            }
        }

        public void ModificaEjecucion(CListaRequeridosBO bo)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("actualizaEjecucionPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Parametros
                    OrdenSql.Parameters.AddWithValue("@_idMultaRif", bo._idMultaRif);
                    OrdenSql.Parameters.AddWithValue("@_ejecucion", bo.Ejecucion);
                    //Abrir la conexion de base de Datos
                    conn.Open();
                    OrdenSql.ExecuteNonQuery();

                }
            }
            catch (MySqlException err)
            {
                throw new ApplicationException("Error Insert Fechas" + err);
            }
        }

        public void ModificaPagoMulta(CListaRequeridosBO bo)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("actualizaPagosMultasPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Parametros
                    OrdenSql.Parameters.AddWithValue("@_idMultaRif", bo._idMultaRif);
                    OrdenSql.Parameters.AddWithValue("@_fechaPago", bo.FechaPago);
                    OrdenSql.Parameters.AddWithValue("@_importe", bo.Importe);
                    OrdenSql.Parameters.AddWithValue("@_ejecucion", bo.Ejecucion);
                    //Abrir la conexion de base de Datos
                    conn.Open();
                    OrdenSql.ExecuteNonQuery();

                }
            }
            catch (MySqlException err)
            {
                throw new ApplicationException("Error Insert Fechas" + err);
            }
        }

        //busqueda masiva de Requerimientos rif
        public ListaClistaRequeridos GetListaBusquedaMasiva(string periodo, string OHE)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("busquedaMasivaPLUS_observaciones", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (periodo == "")
                        periodo = "0";
                    OrdenSql.Parameters.AddWithValue("@_periodo", periodo);
                    OrdenSql.Parameters.AddWithValue("@_OHE", OHE);
                    //Crear conexion para todos los datos
                    ListaClistaRequeridos listOHE = new ListaClistaRequeridos();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        CListaRequeridosBO fila = new CListaRequeridosBO(
                            Convert.ToInt32(lector["numReq"]), //_numReq
                            (string)lector["RFC"], //_RFC
                            (string)lector["numCtrl"],//_numCtrl
                            (string)lector["razonSocial"],//_razonSocial
                            (string)lector["localidad"],//_localidad
                            lector["diligenica"] is DBNull ? "" : ((Int32)lector["diligenica"] == 2 ? "NO TRABAJADO" : ((Int32)lector["diligenica"] == 0 ? "NO LOCALIZADO" : "LOCALIZADO")),//_diligencia                        
                            Convert.ToDateTime(lector["fechaNotificacion"] is DBNull ? null : lector["fechaNotificacion"]),//_fechaNotificacion
                            Convert.ToDateTime(lector["fechaCitatorio"] is DBNull ? null : lector["fechaCitatorio"]),//__fechaCitatorio
                            Convert.ToString(lector["oficioEnvioSEFIPLAN"]),//_oficioSEFIPLAN
                            Convert.ToDateTime(lector["fechaEnvioSEFIPLAN"] is DBNull ? null : lector["fechaEnvioSEFIPLAN"]),//_fechaEnvioSefiplan
                            Convert.ToDateTime(lector["fechaEntregaNotificador"] is DBNull ? null : lector["fechaEntregaNotificador"]),//_fechaEntregaNotificador
                            Convert.ToDateTime(lector["fechaRecepcion"] is DBNull ? null : lector["fechaRecepcion"]),//_fechaRecepcion
                            (string)lector["estatus"],//_estatus
                            Convert.ToBoolean(lector["MalCapturado"] is DBNull ? null : lector["MalCapturado"]),
                            Convert.ToBoolean(lector["ActaNotificacion"] is DBNull ? null : lector["ActaNotificacion"]),
                            Convert.ToBoolean(lector["ActaCitatorio"] is DBNull ? null : lector["ActaCitatorio"]),
                            Convert.ToBoolean(lector["NotificacionCitatorio"] is DBNull ? null : lector["NotificacionCitatorio"]),
                            Convert.ToString(lector["observaciones"]),//_observaciones
                            Convert.ToString(lector["nombreNotificador"] is DBNull ? null : lector["nombreNotificador"])//nombreNotificador
                            ); ;
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
        //busqueda masiva de multasRIF
        public ListaClistaRequeridos GetListaBusquedaMasivaMULTAS(string periodo, string OHE, string tipoMulta) 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("busquedaMasivaMultasPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (periodo == "")
                        periodo = "0";
                    OrdenSql.Parameters.AddWithValue("@idEmision", periodo);
                    OrdenSql.Parameters.AddWithValue("@_OHE", OHE);
                    OrdenSql.Parameters.AddWithValue("@_tipoMulta", tipoMulta);
                    //Crear conexion para todos los datos
                    ListaClistaRequeridos listOHE = new ListaClistaRequeridos();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        CListaRequeridosBO fila = new CListaRequeridosBO(
                            Convert.ToString(lector["idMultaRIF"]),
                            (string)lector["TIPO_MULTA"],
                            Convert.ToInt16(lector["CTRL_MULTA"] is DBNull ? null : lector["CTRL_MULTA"]),
                            (string)lector["rfc"],
                            (string)lector["NUM_CTRL_REQUERIMIENTO"],
                            (string)lector["razonSocial"],
                            (string)lector["detalleEmision"],
                            Convert.ToInt16(lector["numReq"]),
                            lector["diligencia"] is DBNull ? "" : ((Int32)lector["diligencia"] == 2 ? "NO TRABAJADO" : ((Int32)lector["diligencia"] == 0 ? "NO LOCALIZADO" : "LOCALIZADO")),
                            Convert.ToDateTime(lector["fechaCitatorio"] is DBNull ? null : lector["fechaCitatorio"]),//__fechaCitatorio
                            Convert.ToDateTime(lector["fechaNotificacion"] is DBNull ? null : lector["fechaNotificacion"]),//__fechaCitatorio
                            Convert.ToDateTime(lector["fechapago"] is DBNull ? null : lector["fechapago"]),//__fechaCitatorio
                            Convert.ToDouble(lector["importe"] is DBNull ? null : lector["importe"]),
                            Convert.ToDouble(lector["honorarios"] is DBNull ? null : lector["honorarios"]),
                            Convert.ToBoolean(lector["cumplioantes"] is DBNull ? null : lector["cumplioantes"]),
                            Convert.ToDateTime(lector["fechaVencimiento"] is DBNull ? null : lector["fechaVencimiento"]),
                            Convert.ToString(lector["observaciones"] is DBNull ? null : lector["observaciones"]),
                            Convert.ToString(lector["ejecucion"] is DBNull ? null : lector["ejecucion"]),
                            Convert.ToString(lector["estatus"] is DBNull ? null : lector["estatus"])

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
        public ListaClistaRequeridos GetListaBusquedaMultasRIF(string periodo, string OHE, string dataBusqueda) 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("busquedaMultasPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (periodo == "")
                        periodo = "0";
                    OrdenSql.Parameters.AddWithValue("@idEmision", periodo);
                    OrdenSql.Parameters.AddWithValue("@nomOHE", OHE);
                    OrdenSql.Parameters.AddWithValue("@_datoBusqueda", dataBusqueda);
                    //Crear conexion para todos los datos
                    ListaClistaRequeridos listOHE = new ListaClistaRequeridos();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        CListaRequeridosBO fila = new CListaRequeridosBO(
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
                            Convert.ToString(lector["estatus"] is DBNull ? null : lector["estatus"])

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

        public ListaClistaRequeridos GetListadoEjecucionFiscal(string periodo, string OHE)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("GetListaEjecucionPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (periodo == "")
                        periodo = "0";
                    OrdenSql.Parameters.AddWithValue("@idEmision", periodo);
                    OrdenSql.Parameters.AddWithValue("@nomOHE", OHE);
                    //Crear conexion para todos los datos
                    ListaClistaRequeridos listOHE = new ListaClistaRequeridos();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        CListaRequeridosBO fila = new CListaRequeridosBO(
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
                            Convert.ToString(lector["estatus"] is DBNull ? null : lector["estatus"])

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


        public ListaClistaRequeridos GetListaBusqueda(string periodo, string OHE, string dataBusqueda)
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("busquedaListaRequerimientosPLUS_observaciones", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (periodo == "")
                        periodo = "0";
                    OrdenSql.Parameters.AddWithValue("@periodo", periodo);
                    OrdenSql.Parameters.AddWithValue("@OHE", OHE);
                    OrdenSql.Parameters.AddWithValue("@_datoBusqueda", dataBusqueda);
                    //Crear conexion para todos los datos
                    ListaClistaRequeridos listOHE = new ListaClistaRequeridos();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        CListaRequeridosBO fila = new CListaRequeridosBO(
                            Convert.ToInt32(lector["numReq"]), //_numReq
                            (string)lector["RFC"], //_RFC
                            (string)lector["numCtrl"],//_numCtrl
                            (string)lector["razonSocial"],//_razonSocial
                            (string)lector["localidad"],//_localidad
                            lector["diligenica"] is DBNull ? "" : ((Int32)lector["diligenica"] == 2 ? "NO TRABAJADO" : ((Int32)lector["diligenica"] == 0 ? "NO LOCALIZADO" : "LOCALIZADO")),//_diligencia
                            //lector["diligenica"] is DBNull ? "" : ((bool)lector["diligenica"] is false ? "NO LOCALIZADO" : "LOCALIZADO"),//_diligencia
                            Convert.ToDateTime(lector["fechaNotificacion"] is DBNull ? null : lector["fechaNotificacion"]),//_fechaNotificacion
                            Convert.ToDateTime(lector["fechaCitatorio"] is DBNull ? null : lector["fechaCitatorio"]),//__fechaCitatorio
                            Convert.ToString(lector["oficioEnvioSEFIPLAN"]),//_oficioSEFIPLAN
                            Convert.ToDateTime(lector["fechaEnvioSEFIPLAN"] is DBNull ? null : lector["fechaEnvioSEFIPLAN"]),//_fechaEnvioSefiplan
                            Convert.ToDateTime(lector["fechaEntregaNotificador"] is DBNull ? null : lector["fechaEntregaNotificador"]),//_fechaEntregaNotificador
                            Convert.ToDateTime(lector["fechaRecepcion"] is DBNull ? null : lector["fechaRecepcion"]),//_fechaRecepcion                            
                            (string)lector["estatus"],//_estatus
                            Convert.ToBoolean(lector["MalCapturado"] is DBNull ?  null : lector["MalCapturado"]),
                            Convert.ToBoolean(lector["ActaNotificacion"] is DBNull ? null : lector["ActaNotificacion"]),
                            Convert.ToBoolean(lector["ActaCitatorio"] is DBNull ? null : lector["ActaCitatorio"]),
                            Convert.ToBoolean(lector["NotificacionCitatorio"] is DBNull ? null : lector["NotificacionCitatorio"]),
                            Convert.ToString(lector["observaciones"]),//_observaciones
                            Convert.ToString(lector["nombreNotificador"] is DBNull ? null : lector["nombreNotificador"])//nombreNotificador

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

        public async Task<ListaClistaRequeridos> GetMultasRIFSup(string periodo, string OHE)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("tableroRegistroMultasSupervisorPLUS2", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if (periodo == "")
                        periodo = "0";
                    OrdenSql.Parameters.AddWithValue("@idEmision", periodo);
                    OrdenSql.Parameters.AddWithValue("@nomOHE", OHE);
                    //Crear conexion para todos los datos
                    ListaClistaRequeridos listOHE = new ListaClistaRequeridos();
                    conn.Open();
                    MySqlDataReader lector = (MySqlDataReader) await OrdenSql.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                    

                    while (await lector.ReadAsync())
                    {

                        CListaRequeridosBO fila = new CListaRequeridosBO(
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
                            Convert.ToString(lector["estatus"] is DBNull ? null : lector["estatus"]) 
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
        public async Task< ListaClistaRequeridos> GetRequerimientos(string periodo, string OHE) {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("listaRequeridosPLUS_Notificadores", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    if(periodo=="" )
                        periodo="0";
                    OrdenSql.Parameters.AddWithValue("@periodo", periodo);
                    OrdenSql.Parameters.AddWithValue("@OHE", OHE);
                    //Crear conexion para todos los datos
                    ListaClistaRequeridos listOHE = new ListaClistaRequeridos();
                    conn.Open();
                    MySqlDataReader lector = (MySqlDataReader)await OrdenSql.ExecuteReaderAsync(CommandBehavior.CloseConnection);

                    
                    while (await lector.ReadAsync())
                    {

                        CListaRequeridosBO fila = new CListaRequeridosBO();
                        fila.NumReq = Convert.ToInt32(lector["numReq"]); //_numReq
                        fila.Rfc = (string)lector["RFC"]; //_RFC
                        fila.NumCtrl = (string)lector["numCtrl"];//_numCtrl
                        fila.RazonSocial = (string)lector["razonSocial"];//_razonSocial
                        fila.Localidad = (string)lector["localidad"];//_localidad
                        fila.Diligencia = lector["diligenica"] is DBNull ? "" : ((Int32)lector["diligenica"] == 2 ? "NO TRABAJADO" : ((Int32)lector["diligenica"] == 0 ? "NO LOCALIZADO" : "LOCALIZADO"));//_diligencia                        
                        fila.FechaNotificacion = Convert.ToDateTime(lector["fechaNotificacion"] is DBNull ? null : lector["fechaNotificacion"]);//_fechaNotificacion
                        fila.FechaCitatorio = Convert.ToDateTime(lector["fechaCitatorio"] is DBNull ? null : lector["fechaCitatorio"]);//__fechaCitatorio
                        fila.OficioSEFIPLAN = Convert.ToString(lector["oficioEnvioSEFIPLAN"]);//_oficioSEFIPLAN
                        fila.FechaEnvioSefiplan =Convert.ToDateTime(lector["fechaEnvioSEFIPLAN"] is DBNull ? null : lector["fechaEnvioSEFIPLAN"]);//_fechaEnvioSefiplan
                        fila.FechaEntregaNotificador=Convert.ToDateTime(lector["fechaEntregaNotificador"] is DBNull ? null : lector["fechaEntregaNotificador"]);//_fechaEntregaNotificador
                        fila.FechaRecepcion=Convert.ToDateTime(lector["fechaRecepcion"] is DBNull ? null : lector["fechaRecepcion"]);//_fechaRecepcion
                        fila.Estatus = (string)lector["estatus"];//_estatus
                        fila.MalCapturado=Convert.ToBoolean(lector["MalCapturado"] is DBNull ? null : lector["MalCapturado"]);
                        fila.ActaNotificacion=Convert.ToBoolean(lector["ActaNotificacion"] is DBNull ? null : lector["ActaNotificacion"]);
                        fila.ActaCitatorio=Convert.ToBoolean(lector["ActaCitatorio"] is DBNull ? null : lector["ActaCitatorio"]);
                        fila.NotificacionCitatorio=Convert.ToBoolean(lector["NotificacionCitatorio"] is DBNull ? null : lector["NotificacionCitatorio"]);
                        fila.Observaciones=Convert.ToString(lector["observaciones"]);//_observaciones
                        fila.NombreNotificador=Convert.ToString(lector["nombreNotificador"] is DBNull ? null : lector["nombreNotificador"]);//nombreNotificador
                        fila.NotasObservaciones = Convert.ToString(lector["notasObservaciones"] is DBNull ? null : lector["notasObservaciones"]);//nombreNotificador

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

  

        public async Task ModificarRequerimientosRIF(List<CListaRequeridosBO> bo, IProgress<int> progress = null) {
            using var semaforo = new SemaphoreSlim(50);
            var tareas = new List<Task<bool>>();
            var total = bo.Count();


            var i = 0;

            try {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("UpdateDGRequerimientos", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    conn.Open();
                    await Task.Run(() =>
                    {

                        tareas = bo.Select(async r =>
                        {
                            await semaforo.WaitAsync();
                            try
                            {
                                if(progress != null)
                                {
                                    OrdenSql.Parameters.Clear();

                                    i++;

                                    //Parametros
                                    OrdenSql.Parameters.AddWithValue("@_numCtrl", r.NumCtrl);
                                    OrdenSql.Parameters.AddWithValue("@_diligencia", VerificaDiligencia(r.Diligencia, r.FechaNotificacion));
                                    OrdenSql.Parameters.AddWithValue("@_fechaNotificacion", VerificaFecha(r.FechaNotificacion, r.FechaNotificacion, r.Diligencia));
                                    OrdenSql.Parameters.AddWithValue("@_fechaCitatorio", VerificaFecha(r.FechaCitatorio, r.FechaNotificacion, r.Diligencia));
                                    OrdenSql.Parameters.AddWithValue("@_oficioSEFIPLAN", OficioVacio(r.OficioSEFIPLAN, r.FechaNotificacion, r.Diligencia));
                                    OrdenSql.Parameters.AddWithValue("@_fechaEnvioSEFIPLAN", VerificaFecha(r.FechaEnvioSefiplan, r.FechaNotificacion, r.Diligencia));                                
                                    OrdenSql.Parameters.AddWithValue("@_estatus", verificaEstatus(r.Estatus, r.FechaNotificacion, r.Diligencia));
                               
                                    OrdenSql.Parameters.AddWithValue("@_observaciones", r.Observaciones);
                                    OrdenSql.Parameters.AddWithValue("@_notasObservaciones", r.NotasObservaciones);
                                    OrdenSql.Parameters.AddWithValue("@_actaNotificacion", r.ActaNotificacion);
                                    OrdenSql.Parameters.AddWithValue("@_actaCitatorio", r.ActaCitatorio);
                                    OrdenSql.Parameters.AddWithValue("@_notificacionCitatorio", r.NotificacionCitatorio);
                                    OrdenSql.Parameters.AddWithValue("@_nombreNotificador", VerificaNotificador(r.NombreNotificador));



                                    OrdenSql.ExecuteNonQuery();
                                    progress.Report(StaticPercentage.PercentageProgress(i, total));

                                }
                                return r.Modificado;

                            }
                            finally
                            {
                                semaforo.Release();
                            }

                            
                        }).ToList();
                    });

                    await Task.WhenAll(tareas);

               

                }
            } catch (MySqlException err) {
                throw new ApplicationException("Error Insert Fechas" + err);
            }

        }



        public async Task ModificaMultasRif(List<CListaRequeridosBO> bo, IProgress<int> progress = null) 
        {
            using var semaforo = new SemaphoreSlim(50);
            var tareas = new List<Task<bool>>();
            var total = bo.Count();

            var i = 0;
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("actualizaMultasPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    conn.Open();

                    await Task.Run(() =>
                    {

                        tareas = bo.Select(async r =>
                        {
                            await semaforo.WaitAsync();
                            try
                            {
                                if (progress != null)
                                {
                                    OrdenSql.Parameters.Clear();

                                    i++;

                                    //Parametros
                                    OrdenSql.Parameters.AddWithValue("@_idMultaRif", r._idMultaRif);//cumplioAntes
                                    OrdenSql.Parameters.AddWithValue("@_diligencia", VerificaDiligencia(r.Diligencia, r.FechaNotificacion));//diligencia
                                    OrdenSql.Parameters.AddWithValue("@_fechaNotificacion", VerificaFecha(r.FechaNotificacion, r.FechaNotificacion, r.Diligencia));//notificacion
                                    OrdenSql.Parameters.AddWithValue("@_fechaCitatorio", VerificaFecha(r.FechaCitatorio, r.FechaNotificacion, r.Diligencia));//citatorio
                                    OrdenSql.Parameters.AddWithValue("@_fechaPagoMulta", VerificaPAgo(r.FechaPago, r.FechaNotificacion, r.Diligencia, r.Importe));//pagoMulta
                                    OrdenSql.Parameters.AddWithValue("@_importePagoMulta", VerificaImporte(r.Importe, r.Diligencia, r.FechaNotificacion, r.FechaPago));//importeMulta
                                    OrdenSql.Parameters.AddWithValue("@_honorarios", VerificaHonorarios(r.Honorarios, r.Diligencia, r.Importe, r.FechaPago));//importeMulta
                                    OrdenSql.Parameters.AddWithValue("@_cumplioAntes", verificaCumplioAntes(r.CumplioAntes, r.Diligencia));//cumplioAntes
                                    OrdenSql.Parameters.AddWithValue("@_fechaVencimientoMulta", VerificaFecha(r._fechaVencimiento, r.FechaNotificacion, r.Diligencia));//fechaVencimiento
                                    OrdenSql.Parameters.AddWithValue("@_estatus", verificaEstatus(r.Estatus, r.FechaNotificacion, r.Diligencia));//estatus
                                    OrdenSql.Parameters.AddWithValue("@_ejecucion", verificaEjecucion(r.Ejecucion, r.Diligencia, r.FechaNotificacion, r.FechaPago, r._fechaVencimiento, r.Importe));//estatus
                                    OrdenSql.Parameters.AddWithValue("@_observaciones", r.Observaciones);



                                    OrdenSql.ExecuteNonQuery();
                                    progress.Report(StaticPercentage.PercentageProgress(i, total));

                                }
                                return r.Modificado;

                            }
                            finally
                            {
                                semaforo.Release();
                            }


                        }).ToList();
                    });

                    await Task.WhenAll(tareas);
                    


                    //Abrir la conexion de base de Datos

                }
            }
            catch (MySqlException err)
            {
                throw new ApplicationException("Error Insert Fechas" + err);
            }

        }

        //metodos internos 
        #region Métodos de verificación
        private string VerificaNotificador(string nombreNotificador)
        {
            try
            {
                if (nombreNotificador == "" || nombreNotificador != null)
                {
                    if (!nombreNotificador.Contains("/")) 
                    {
                        CNotificadoresBO notificadores = CUserLoggin.Notificadores.FirstOrDefault(x => x.ClaveNotificador.Equals(nombreNotificador));
                        return notificadores.IdNotificador.ToString();

                    }

                    var id =  nombreNotificador.Length > 0 ? nombreNotificador.Substring(0, nombreNotificador.IndexOf("/")) : nombreNotificador;
                    CNotificadoresBO notificador = CUserLoggin.Notificadores.FirstOrDefault(x => x.ClaveNotificador.Equals(id));
                    return notificador.IdNotificador.ToString();
                }

                return null;
            }
            catch (NullReferenceException)
            {

                return null;
            }
        }
        private object VerificaPAgo(DateTime fechaPago, DateTime fechaNotificacion, string diligencia, double importe)
        {


            if (diligencia == "" || fechaNotificacion == Convert.ToDateTime("01/01/0001")|| importe ==0)
            {

                return null;

            }

            return fechaPago;

        }

        private object verificaEjecucion(string ejecucion, string diligencia, DateTime fechaNotificacion, DateTime fechaPago, DateTime fechaVencimiento, double importe)
        {
            if (diligencia == "LOCALIZADO" && fechaNotificacion != Convert.ToDateTime("01/01/0001") && importe == 0 && fechaVencimiento <= DateTime.Today )
                ejecucion = "vencida";
            else if (diligencia == "LOCALIZADO" && importe > 0 )//fecha notificación
                ejecucion = "pagada";
            else
                ejecucion = "activa";

            return ejecucion;
        }


        private object VerificaImporte(double importe, string diligencia, DateTime fechaNotificacion, DateTime fechaPago)
        {
            
            
                if ((diligencia == "" || fechaNotificacion == Convert.ToDateTime("01/01/0001")|| fechaPago == Convert.ToDateTime("01/01/0001")))
                    importe = 0;
                return importe;
            
        }

        private object VerificaHonorarios(double honorarios, string diligencia, double importe, DateTime fechaPago)
        {
            if ((fechaPago == Convert.ToDateTime("01/01/0001") || diligencia == "" || importe == 0))
                honorarios = 0;
            return honorarios;
        }

        private object verificaCumplioAntes(bool cumplioAntes, string diligencia)
        {
            if (diligencia == "")
                cumplioAntes = false;
            
            return cumplioAntes;
        }





        private object verificaEstatus(string estatus, DateTime fechaNotificacion,string setDiligencia )
        {
                if ((fechaNotificacion == Convert.ToDateTime("01/01/0001") && setDiligencia != "NO TRABAJADO") || setDiligencia == "")
                    estatus = "pendiente";
                else
                if (estatus == "pendiente")
                    estatus = "listo";
                else if (estatus == "enviado")
                    estatus = "enviado";
                else if (estatus == "listo")
                    estatus = "listo";




            return estatus;
        }

        private object VerificaDiligencia(string setDiligencia, DateTime fechaCitatiro)
        {
            if (fechaCitatiro == Convert.ToDateTime("01/01/0001")) return null;
            else if (setDiligencia.Equals("NO TRABAJADO"))
            {
                return 2;
            }
            else if (setDiligencia == "")
            {
                MessageBox.Show("la columna [Localizado No Localizado] debe contener un valor");
                return null;

            }
            else if (setDiligencia == "LOCALIZADO")
                return 1;
            else
                return 0;



        }
        

        private object OficioVacio(string oFICIO_SEFIPLAN, DateTime FechaNotificacion, string setDiligencia)
        {
            if (oFICIO_SEFIPLAN == null || FechaNotificacion == Convert.ToDateTime("01/01/0001")|| setDiligencia == "") return null;
            else
                return oFICIO_SEFIPLAN;
        }

        private object VerificaFecha(DateTime fECHA_DILIGENCIA, DateTime FechaNotificacion, string setDiligencia)
        {
            if (FechaNotificacion == Convert.ToDateTime("01/01/0001") || setDiligencia == "")
            {
                
                return null;
                    
            }

                if (fECHA_DILIGENCIA < Convert.ToDateTime("01/01/0001")) return null;
                else
                {
                    return fECHA_DILIGENCIA;
                }
        }
        #endregion


        //seccion de métodos de la factory
        #region Factory
        public override  async Task ObservacionesRequerimientos(List<CListaRequeridosBO> bo)
        {
            await ModificarObservacionesRIF(bo, reportarProgreso);
        }

        public override async Task ModificarRequerimientos(List<CListaRequeridosBO> bo)
        {
           await ModificarRequerimientosRIF(bo, reportarProgreso);
        }

        public override async Task<ListaClistaRequeridos> Requerimientos(string periodo, string OHE)
        {
            return await GetRequerimientos(periodo, OHE);
        }

        public override async Task ObservacionesMultas(CListaRequeridosBO bo)
        {
            
            ModificaObservacionesMultasRIF(bo);
        }

        

        public override async Task EjecucionMulta(CListaRequeridosBO bo)
        {
            ModificaEjecucion(bo);
        }

        public override async Task PagoMulta(CListaRequeridosBO bo)
        {
            ModificaPagoMulta(bo);
        }



        public override async Task ModificaMultas(List<CListaRequeridosBO> bo)
        {
           await  ModificaMultasRif(bo,reportarProgreso);
        }

        public override ListaClistaRequeridos ListaBusquedaMasiva(string periodo, string OHE)
        {
            return GetListaBusquedaMasiva(periodo, OHE);
        }

        public override ListaClistaRequeridos ListaBusquedaMasivaMULTAS(string periodo, string OHE, string tipoMulta)
        {
            return GetListaBusquedaMasivaMULTAS(periodo, OHE, tipoMulta);
        }

        public override ListaClistaRequeridos ListaBusquedaMultasRIF(string periodo, string OHE, string dataBusqueda)
        {
            return GetListaBusquedaMultasRIF(periodo, OHE, dataBusqueda);
        }

        public override ListaClistaRequeridos ListadoEjecucionFiscal(string periodo, string OHE)
        {
            return GetListadoEjecucionFiscal(periodo, OHE);
        }

        public override ListaClistaRequeridos ListaBusqueda(string periodo, string OHE, string dataBusqueda)
        {
            return GetListaBusqueda(periodo, OHE, dataBusqueda);
        }

        public override async Task<ListaClistaRequeridos> MultasRIFSup(string periodo, string OHE)
        {
            return await GetMultasRIFSup(periodo, OHE);
        }


        #endregion



        public override void ReportarProgreso(int porcentaje)
        {

            _progressBar.Value = porcentaje;

            if (porcentaje != 100 && porcentaje > 0)
            {
                _lblProgress.Text = string.Format("procesando...{0}% ", porcentaje);
            }
            else
            {
                _lblProgress.Text = "Listo.";
            }
        }
    }
}
