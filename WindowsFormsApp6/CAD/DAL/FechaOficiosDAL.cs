using CleanArchitecture.ClasesDB;
using CleanArchitecture.Concretas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.CAD.DAL
{
    public class FechaOficiosDAL 
    {
        private readonly string strConn;
        
        public FechaOficiosDAL()
        {
            strConn = System.Configuration.ConfigurationManager.AppSettings["k1"];
            
        }

        public FechaOficiosDAL(string conn)
        {
            strConn = conn;
        }

        public async Task<ListFechaOficios> GetFechaOficios(string idEmision)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("GetFechaOficios", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_idEmision", idEmision);
                    //Crear conexion para todos los datos
                    ListFechaOficios listURL = new ListFechaOficios();
                    conn.Open();
                    MySqlDataReader lector = (MySqlDataReader)await OrdenSql.ExecuteReaderAsync();

                    while (await lector.ReadAsync())
                    {
                        fechaOficios fila = new fechaOficios(
                                (string)lector["IdEmision"],
                                Convert.ToDateTime(lector["FechaRetro"] is DBNull ? null : lector["FechaRetro"] ),
                                Convert.ToDateTime(lector["fechaOficios"] is DBNull ? new DateTime() : lector["fechaOficios"]
                                
                                )) ;
                        listURL.Add(fila);
                    }

                    return listURL;
                }

            }

            catch (Exception)
            {

                throw;
            }
        }

        public void ModificaFechasOficios(fechaOficios bo) 
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("SetFechaOficios", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Parametros
                    OrdenSql.Parameters.AddWithValue("@_idEmision", bo.IdEmision);
                    OrdenSql.Parameters.AddWithValue("@_fechaOficio", bo.FechaOficios);
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

        public void ModificaFechaRetro(fechaOficios bo)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("SetFechaRetroOficios", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Parametros
                    OrdenSql.Parameters.AddWithValue("@_idEmision", bo.IdEmision);
                    OrdenSql.Parameters.AddWithValue("@_fechaRetro", bo.FechaRetro);
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

    }
}
