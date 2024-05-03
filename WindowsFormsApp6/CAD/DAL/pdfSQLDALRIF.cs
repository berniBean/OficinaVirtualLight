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

    public class pdfSQLDALRIF : obtenerPDFSql
    {
        private readonly string strConn;
        public pdfSQLDALRIF()
        {
            strConn = System.Configuration.ConfigurationManager.AppSettings["k1"];

        }

        private async Task<ListPdfSql> GetPDFSqlRIF(int idEmision)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("pdfSqlRIF", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    OrdenSql.Parameters.AddWithValue("@idEmision", idEmision);
                    //Crear conexion para todos los datos
                    ListPdfSql listpdfSql = new ListPdfSql();
                    conn.Open();
                    MySqlDataReader lector = (MySqlDataReader)await OrdenSql.ExecuteReaderAsync();

                    while (await lector.ReadAsync())
                    {
                        //lector["fechaCitatorio"] is DBNull ? null : lector["fechaCitatorio"]
                        pdfSQL fila = new pdfSQL(
                            (string)lector["numReq"],
                            (string)lector["numCtrl"],
                            Convert.ToString(lector["PDF"] is DBNull ? "pendiente" : lector["PDF"]),
                            (string)lector["ohe"]);
                        listpdfSql.Add(fila);
                    }

                    return listpdfSql;

                }
            }
            catch (MySqlException e)
            {
                throw new ApplicationException("Error " + e);
            }
        }

        private async Task modificaEstatusRifPDF(pdfSQL pdfSQL)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("pdfRequerimientosRIFSubidos", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Parametros
                    OrdenSql.Parameters.AddWithValue("@_numCtrl", pdfSQL.numCtrl);
                    OrdenSql.Parameters.AddWithValue("@_estatus", pdfSQL.estatusPDF);
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
        private async Task<ListPdfSql> GetPdFRIFMUltasSQl(int idEmision)
        {
            //pdfSqlMultaPLUS
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("pdfSqlMultaRIF", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    OrdenSql.Parameters.AddWithValue("@idEmision", idEmision);
                    //Crear conexion para todos los datos
                    ListPdfSql listpdfSql = new ListPdfSql();
                    conn.Open();
                    MySqlDataReader lector = (MySqlDataReader)await OrdenSql.ExecuteReaderAsync();

                    while (await lector.ReadAsync())
                    {

                        pdfSQL fila = new pdfSQL(
                            (string)lector["numReq"],
                            (string)lector["numCtrl"],
                            Convert.ToString(lector["PDF"] is DBNull ? null : lector["PDF"]),                            
                            (string)lector["ohe"]);
                        listpdfSql.Add(fila);
                    }

                    return listpdfSql;

                }
            }
            catch (MySqlException e)
            {
                throw new ApplicationException("Error " + e);
            }
        }

        private async Task modificaEstatusPDFMultasRIF(pdfSQL pdfSQL)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("pdfMultasRIFSubidos", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Parametros
                    OrdenSql.Parameters.AddWithValue("@_numCtrl", pdfSQL.numCtrl);
                    OrdenSql.Parameters.AddWithValue("@_estatus", pdfSQL.estatusPDF);
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

        public override async  Task<ListPdfSql> listadoPDFSql(int idEmision)
        {
            return await GetPDFSqlRIF(idEmision);
        }

        public override Task modificaEstatusPDf(pdfSQL pdfSQL)
        {
            return modificaEstatusRifPDF(pdfSQL);
        }

        public override Task<ListPdfSql> listadoPdfMultasSql(int idEmision)
        {
            return GetPdFRIFMUltasSQl(idEmision);
        }

        public override async Task modificaEstatusMultaPDf(pdfSQL pdfSQL)
        {
            await modificaEstatusPDFMultasRIF(pdfSQL);
        }

        public override Task<ListPdfSql> ListadoPdfFirmados(int idEmision)
        {
            throw new NotImplementedException();
        }

        public override Task<ListPdfSql> listadoPdfMultasFirmadosSql(int idEmision)
        {
            throw new NotImplementedException();
        }

        public override Task<ListPdfSql> listadoOficiosPDF(int idEmision, int idSup)
        {
            throw new NotImplementedException();
        }

        public override Task<ListPdfSql> listadoOficiosMultasPDF(int idEmision, int idSup)
        {
            throw new NotImplementedException();
        }

        public override Task<ListPdfSql> listadoRecibosMultasPDF(int idEmision, int idSup)
        {
            throw new NotImplementedException();
        }
    }
}
