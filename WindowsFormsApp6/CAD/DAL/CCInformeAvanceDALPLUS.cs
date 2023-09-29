using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;
using System.Data;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6.CAD.DAL
{
    public class CCInformeAvanceDALPLUS : obtenerInformes
    {
        private readonly string strConn;

        public CCInformeAvanceDALPLUS() {
            strConn = System.Configuration.ConfigurationManager.AppSettings["K1"]; ;
        }

        public CCInformeAvanceDALPLUS(string conn)
        {
            strConn = conn;
        }



        public ListaInformeAvance GetAvanceAdmin(int emision) 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("avanceEmisionGeneralPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_Emision", emision);
                    ListaInformeAvance listAvance = new ListaInformeAvance();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {
                        CInformeAvance fila = new CInformeAvance(
                               Convert.ToString(lector["referenciaNumerica"] is DBNull ? null : lector["referenciaNumerica"]),
                                Convert.ToDateTime(lector["fechaImpresion"] is DBNull ? null : lector["fechaImpresion"]),
                                Convert.ToString(lector["nomEmision"] is DBNull ? null : lector["nomEmision"]),
                                Convert.ToString(lector["zona"] is DBNull ? null : lector["zona"]),
                                Convert.ToString(lector["OHE"] is DBNull ? null : lector["OHE"]),
                                Convert.ToInt16(lector["Total"] is DBNull ? 0 : lector["Total"]),
                                Convert.ToInt16(lector["pendientes"] is DBNull ? 0 : lector["pendientes"]),
                                Convert.ToInt16(lector["Requeridos"] is DBNull ? 0 : lector["Requeridos"]),
                                Convert.ToInt16(lector["Localizado"] is DBNull ? 0 : lector["Localizado"]),
                                Convert.ToInt16(lector["Nolocalizado"] is DBNull ? 0 : lector["Nolocalizado"]),
                                Convert.ToInt16(lector["Notrabajado"] is DBNull ? 0 : lector["Notrabajado"]),
                                Convert.ToInt16(lector["Preparados"] is DBNull ? 0 : lector["Preparados"])
                            );
                        listAvance.Add(fila);
                    }
                    return listAvance;
                }
            }
            catch (MySqlException e)
            {
                throw new ApplicationException("Error " + e);
            }
        }

         
        public ListaInformeAvance GetAvanceMultaSup(int emision, int supervisor)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("tablaMultasSupervisorPLUSXPDF2", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@idEmision", emision);
                    OrdenSql.Parameters.AddWithValue("@idSupervisor", supervisor);
                    ListaInformeAvance listAvance = new ListaInformeAvance();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {
                        CInformeAvance fila = new CInformeAvance(
                                Convert.ToString(lector["zona"] is DBNull ? null : lector["zona"]),
                                Convert.ToString(lector["OHE"] is DBNull ? null : lector["OHE"]),
                                Convert.ToInt16(lector["extp"] is DBNull ? 0 : lector["extp"]),
                                Convert.ToInt16(lector["incp"] is DBNull ? 0 : lector["incp"]),
                                Convert.ToInt16(lector["emitido"] is DBNull ? 0 : lector["emitido"]),
                                Convert.ToInt16(lector["pendiente"] is DBNull ? 0 : lector["pendiente"]),
                                Convert.ToInt16(lector["Localizado"] is DBNull ? 0 : lector["Localizado"]),
                                Convert.ToInt16(lector["Nolocalizado"] is DBNull ? 0 : lector["Nolocalizado"]),
                                Convert.ToInt16(lector["Notrabajado"] is DBNull ? 0 : lector["Notrabajado"]),
                                Convert.ToInt16(lector["vencidos"] is DBNull ? 0 : lector["vencidos"]),
                                Convert.ToInt16(lector["cobrados"] is DBNull ? 0 : lector["cobrados"]),
                                Convert.ToInt32(lector["total"] is DBNull ? 0 : lector["total"]),
                                Convert.ToInt32(lector["honorarios"] is DBNull ? 0 : lector["honorarios"]),
                                Convert.ToInt32(lector["pendientePDF"] is DBNull ? 0 : lector["pendientePDF"])
                            );
                        listAvance.Add(fila);
                    }
                    return listAvance;
                }
            }
            catch (MySqlException e)
            {
                throw new ApplicationException("Error " + e);
            }
        }

        public ListaInformeAvance GetAvancesRIF(int emision, int supervisor)
        {
            try {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("getAvancesZonaPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_Emision", emision);
                    OrdenSql.Parameters.AddWithValue("@_supervisor", supervisor);
                    ListaInformeAvance listAvance = new ListaInformeAvance();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {
                        CInformeAvance fila = new CInformeAvance(
                                Convert.ToString(lector["OHE"] is DBNull ? null : lector["OHE"]),
                                Convert.ToInt16(lector["Total"] is DBNull ? 0 : lector["Total"]),
                                Convert.ToInt16(lector["pendientes"] is DBNull ? 0 : lector["pendientes"]),
                                Convert.ToInt16(lector["Requeridos"] is DBNull ? 0 : lector["Requeridos"]),
                                Convert.ToInt16(lector["Localizado"] is DBNull ? 0 : lector["Localizado"]),                            
                                Convert.ToInt16(lector["Nolocalizado"] is DBNull ? 0 : lector["Nolocalizado"]),
                                Convert.ToInt16(lector["Notrabajado"] is DBNull ? 0 : lector["Notrabajado"])
                            );
                        listAvance.Add(fila);
                    }
                    return listAvance;
                } 
            } catch (MySqlException e) {
                throw new ApplicationException("Error " + e);
            }
        }
        public override ListaInformeAvance AvanceAdmin(int emision)
        {
            return GetAvanceAdmin(emision);
        }

        public override ListaInformeAvance AvanceMultaSup(int emision, int supervisor)
        {
            return GetAvanceMultaSup(emision, supervisor);
        }

        public override ListaInformeAvance AvancesReq(int emision, int supervisor)
        {
            return GetAvancesRIF(emision, supervisor);
        }
    }
}
