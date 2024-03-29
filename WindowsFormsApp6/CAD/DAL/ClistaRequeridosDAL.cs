﻿using MySql.Data.MySqlClient;
using System;
using WindowsFormsApp6.CAD.BO;
using System.Data;

using System.Windows.Forms;
using WindowsFormsApp6.CAD.DAL.factories;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WindowsFormsApp6.CAD.DAL
{
    class ClistaRequeridosDAL : obtenerRequeridos
    {
        private readonly string strConn;

        public ClistaRequeridosDAL() {
            strConn = System.Configuration.ConfigurationManager.AppSettings["K1"];
        }

        public ClistaRequeridosDAL(string conn) {
            strConn = conn;
        }
        
        public void ModificaObservacionesMultasRIF(CListaRequeridosBO bo) 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("observacionesMultas", conn)
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

        public async Task ModificarObservacionesRIF(List<CListaRequeridosBO> bo)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("actualizaObservaciones", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    conn.Open();
                    foreach (var item in bo)
                    {
                        //Parametros
                        OrdenSql.Parameters.AddWithValue("@_numCtrl", item.NumCtrl);
                        OrdenSql.Parameters.AddWithValue("@_observaciones", item.Observaciones);
                        OrdenSql.ExecuteNonQuery();
                    }


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
                    MySqlCommand OrdenSql = new MySqlCommand("actualizaEjecucion", conn)
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
                    MySqlCommand OrdenSql = new MySqlCommand("actualizaPagosMultas", conn)
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
                    MySqlCommand OrdenSql = new MySqlCommand("busquedaMasiva_observaciones", conn)
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
        //busqueda masiva de multasRIF
        public ListaClistaRequeridos GetListaBusquedaMasivaMULTAS(string periodo, string OHE, string tipoMulta) 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("busquedaMasivaMultas", conn)
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
                    MySqlCommand OrdenSql = new MySqlCommand("busquedaMultasRIF", conn)
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
                    MySqlCommand OrdenSql = new MySqlCommand("GetListaEjecucion", conn)
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
                    MySqlCommand OrdenSql = new MySqlCommand("busquedaListaRequerimientos_observaciones", conn)
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
                            Convert.ToBoolean(lector["MalCapturado"] is DBNull ? null : lector["MalCapturado"]),
                            Convert.ToBoolean(lector["ActaNotificacion"] is DBNull ? null : lector["ActaNotificacion"]),
                            Convert.ToBoolean(lector["ActaCitatorio"] is DBNull ? null : lector["ActaCitatorio"]),
                            Convert.ToBoolean(lector["NotificacionCitatorio"] is DBNull ? null : lector["NotificacionCitatorio"]),
                            Convert.ToString(lector["observaciones"]),//_observaciones
                            Convert.ToString(lector["nombreNotificador"] is DBNull ? null : lector["nombreNotificador"])//nombreNotificador

                            ) ;
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
                    MySqlCommand OrdenSql = new MySqlCommand("tableroRegistroMultasSupervisor", conn)
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
        public ListaClistaRequeridos GetRequerimientos(string periodo, string OHE) {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("listaRequeridos_observaciones", conn)
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
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        CListaRequeridosBO fila = new CListaRequeridosBO(
                            Convert.ToInt32(lector["numReq"]), //_numReq
                            (string)lector["RFC"], //_RFC
                            (string)lector["numCtrl"],//_numCtrl
                            (string)lector["razonSocial"],//_razonSocial
                            (string)lector["localidad"],//_localidad
                            lector["diligenica"] is DBNull ? "" : ((Int32)lector["diligenica"] == 2 ? "NO TRABAJADO" :((Int32)lector["diligenica"] == 0 ? "NO LOCALIZADO":"LOCALIZADO")),//_diligencia                        
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

                            //Convert.ToInt32(lector["numReq"]), //_numReq
                            // (string)lector["RFC"], //_RFC
                            // (string)lector["numCtrl"],//_numCtrl
                            // (string)lector["razonSocial"],//_razonSocial
                            // (string)lector["localidad"],//_localidad
                            // lector["diligenica"] is DBNull ? "" : ((Int32)lector["diligenica"] == 2 ? "NO TRABAJADO" : ((Int32)lector["diligenica"] == 0 ? "NO LOCALIZADO" : "LOCALIZADO")),//_diligencia                        
                            // Convert.ToDateTime(lector["fechaNotificacion"] is DBNull ? null : lector["fechaNotificacion"]),//_fechaNotificacion
                            // Convert.ToDateTime(lector["fechaCitatorio"] is DBNull ? null : lector["fechaCitatorio"]),//__fechaCitatorio
                            // Convert.ToString(lector["oficioEnvioSEFIPLAN"]),//_oficioSEFIPLAN
                            // Convert.ToDateTime(lector["fechaEnvioSEFIPLAN"] is DBNull ? null : lector["fechaEnvioSEFIPLAN"]),//_fechaEnvioSefiplan
                            // Convert.ToDateTime(lector["fechaEntregaNotificador"] is DBNull ? null : lector["fechaEntregaNotificador"]),//_fechaEntregaNotificador
                            // Convert.ToDateTime(lector["fechaRecepcion"] is DBNull ? null : lector["fechaRecepcion"]),//_fechaRecepcion
                            // (string)lector["estatus"],//_estatus
                            // Convert.ToString(lector["observaciones"]),//_observaciones
                            // Convert.ToString(lector["nombreNotificador"] is DBNull ? null : lector["nombreNotificador"])//nombreNotificador


                            );;
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

  

        public void ModificarRequerimientosRIF(CListaRequeridosBO bo) {
            try {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("actualizaDatosRequerimiento", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Parametros
                    OrdenSql.Parameters.AddWithValue("@_diligencia", VerificaDiligencia(bo.Diligencia, bo.FechaNotificacion));
                    OrdenSql.Parameters.AddWithValue("@_fechaNotificacion", VerificaFecha(bo.FechaNotificacion, bo.FechaNotificacion, bo.Diligencia));
                    OrdenSql.Parameters.AddWithValue("@_fechaCitatorio", VerificaFecha(bo.FechaCitatorio, bo.FechaNotificacion, bo.Diligencia));
                    OrdenSql.Parameters.AddWithValue("@_oficioSEFIPLAN", OficioVacio(bo.OficioSEFIPLAN, bo.FechaNotificacion, bo.Diligencia));
                    OrdenSql.Parameters.AddWithValue("@_fechaEnvioSEFIPLAN", VerificaFecha(bo.FechaEnvioSefiplan, bo.FechaNotificacion, bo.Diligencia));
                    OrdenSql.Parameters.AddWithValue("@_numCtrl", bo.NumCtrl);
                    OrdenSql.Parameters.AddWithValue("@_estatus", verificaEstatus(bo.Estatus, bo.FechaNotificacion, bo.Modificado, bo.Diligencia));
                    OrdenSql.Parameters.AddWithValue("@_nombreNotificador", bo.NombreNotificador);
                    //OrdenSql.Parameters.AddWithValue("@_observaciones", OficioVacio(bo.Observaciones));
                    //Abrir la conexion de base de Datos
                    conn.Open();
                    OrdenSql.ExecuteNonQuery();

                }
            } catch (MySqlException err) {
                throw new ApplicationException("Error Insert Fechas" + err);
            }

        }

        public void ModificaMultasRif(CListaRequeridosBO bo)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("actualizaMultasRIF", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Parametros
                    OrdenSql.Parameters.AddWithValue("@_idMultaRif", bo._idMultaRif);//cumplioAntes
                    OrdenSql.Parameters.AddWithValue("@_diligencia", VerificaDiligencia(bo.Diligencia, bo.FechaNotificacion));//diligencia
                    OrdenSql.Parameters.AddWithValue("@_fechaNotificacion", VerificaFecha(bo.FechaNotificacion, bo.FechaNotificacion, bo.Diligencia));//notificacion
                    OrdenSql.Parameters.AddWithValue("@_fechaCitatorio", VerificaFecha(bo.FechaCitatorio, bo.FechaNotificacion, bo.Diligencia));//citatorio
                    OrdenSql.Parameters.AddWithValue("@_fechaPagoMulta", VerificaPAgo(bo.FechaPago,bo.FechaNotificacion, bo.Diligencia,bo.Importe));//pagoMulta
                    OrdenSql.Parameters.AddWithValue("@_importePagoMulta",VerificaImporte( bo.Importe, bo.Diligencia, bo.FechaNotificacion, bo.FechaPago));//importeMulta
                    OrdenSql.Parameters.AddWithValue("@_honorarios", VerificaHonorarios( bo.Honorarios, bo.Diligencia, bo.Importe, bo.FechaPago));//importeMulta
                    OrdenSql.Parameters.AddWithValue("@_cumplioAntes",verificaCumplioAntes( bo.CumplioAntes, bo.Diligencia));//cumplioAntes
                    OrdenSql.Parameters.AddWithValue("@_fechaVencimientoMulta", VerificaFecha(bo._fechaVencimiento, bo.FechaNotificacion, bo.Diligencia));//fechaVencimiento
                    OrdenSql.Parameters.AddWithValue("@_estatus", verificaEstatus(bo.Estatus, bo.FechaNotificacion, bo.Modificado, bo.Diligencia));//estatus
                    OrdenSql.Parameters.AddWithValue("@_ejecucion",verificaEjecucion(bo.Ejecucion,bo.Diligencia, bo.FechaNotificacion, bo.FechaPago, bo._fechaVencimiento, bo.Importe));//estatus
                    //OrdenSql.Parameters.AddWithValue("@_observaciones", OficioVacio(bo.Observaciones));
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





        private object verificaEstatus(string estatus, DateTime fechaNotificacion, bool Modificado,string setDiligencia )
        {
            if (Modificado != false) 
                if ((fechaNotificacion == Convert.ToDateTime("01/01/0001")&& setDiligencia !="NO TRABAJADO")|| setDiligencia == "")
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
            if (fechaCitatiro == Convert.ToDateTime("01/01/0001") && setDiligencia != "NO TRABAJADO") return null;
            else if(fechaCitatiro == Convert.ToDateTime("01/01/0001") && setDiligencia.Equals("NO TRABAJADO"))
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

        public override async Task ObservacionesRequerimientos(List<CListaRequeridosBO> bo)
        {
            ModificarObservacionesRIF(bo);
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

        //public override void ModificarRequerimientos(CListaRequeridosBO bo)
        //{
        //    ModificarRequerimientosRIF(bo);
        //}

        public override async Task ModificaMultas(List<CListaRequeridosBO> bo)
        {
            throw new NotImplementedException();
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

        //public override async Task<ListaClistaRequeridos> MultasRIFSup(string periodo, string OHE)
        //{
        //    return await GetMultasRIFSup(periodo, OHE);
        //}

        public override Task<ListaClistaRequeridos> Requerimientos(string periodo, string OHE)
        {
            throw new NotImplementedException();
        }

        public override void ReportarProgreso(int porcentaje)
        {
            throw new NotImplementedException();
        }

        public override Task ModificarRequerimientos(List<CListaRequeridosBO> bo)
        {
            throw new NotImplementedException();
        }


        public override Task<ListaClistaRequeridos> MultasRIFSup(string periodo, string OHE)
        {
            throw new NotImplementedException();
        }
    }
}
