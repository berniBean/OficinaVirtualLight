using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6.CAD.DAL
{
    public class pdfSQLDALPLUS : obtenerPDFSql
    {
        private readonly string strConn;
        public pdfSQLDALPLUS()
        {
            strConn = System.Configuration.ConfigurationManager.AppSettings["k1"];

        }

        private async Task<ListPdfSql> GetPdfSQLFirmados(int idEmision)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("pdfSqlFirmadosPlus", conn)
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
                            (string)lector["PDF"],
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

        private async Task<ListPdfSql> GetPdfSQL(int idEmision)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("pdfSql", conn)
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
                            (string)lector["PDF"],
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

        private async Task<ListPdfSql> GetPdfMultasFirmadas(int idEmision)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("pdfSqlMultaFirmadasPLUS", conn)
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
                            (string)lector["PDF"],
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

        private async Task<ListPdfSql> GetPdfPLUSQl(int idEmision)
        {
            //pdfSqlMultaPLUS
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("pdfSqlMultaPLUS", conn)
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
                            (string)lector["PDF"],
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
        private async Task modificaEstatusPDFMultasPLUS(pdfSQL pdfSQL) 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("pdfMultasPLUSSubidos", conn)
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
        private async Task modificaEstatusRequerimientosPLUSPdf(pdfSQL pdfSQL)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("pdfRequerimientosPLUSSubidos", conn)
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
        public override async Task<ListPdfSql> listadoPDFSql(int idEmision)
        {
            return await GetPdfSQL(idEmision);
        }

        public override async Task<ListPdfSql> ListadoPdfFirmados(int idEmision)
        {
            return await GetPdfSQLFirmados(idEmision);
        }



        public override async Task modificaEstatusPDf(pdfSQL pdfSQL)
        {
           await modificaEstatusRequerimientosPLUSPdf(pdfSQL);
        }

        public override async Task<ListPdfSql> listadoPdfMultasSql(int idEmision)
        {
            return await GetPdfPLUSQl(idEmision);
        }
        public override async Task<ListPdfSql> listadoPdfMultasFirmadosSql(int idEmision)
        {
            return await GetPdfMultasFirmadas(idEmision);
        }



        public override async Task modificaEstatusMultaPDf(pdfSQL pdfSQL)
        {
            await modificaEstatusPDFMultasPLUS(pdfSQL);
        }


    }
}
