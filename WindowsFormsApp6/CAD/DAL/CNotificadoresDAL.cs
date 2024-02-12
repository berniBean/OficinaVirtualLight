using MySql.Data.MySqlClient;
using System;
using System.Data;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.CAD.DAL
{
    public class CNotificadoresDAL
    {

        private readonly string StrConn;
        private readonly CNotificadoresBO _catNotificadores;
        public CNotificadoresDAL()
        {
            StrConn = System.Configuration.ConfigurationManager.AppSettings["k1"];
        }

        public CNotificadoresDAL(CNotificadoresBO catNotificadores)
        {
            _catNotificadores = catNotificadores;
        }

       
        public CListNotificadores GetNotificadorSupervisor(int idSupervisor)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(StrConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("GetNotificadoresSupervisor", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_idSupervisor", idSupervisor);

                    //Crear conexion para todos los datos
                    CListNotificadores listNotificadores = new CListNotificadores();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {


                        CNotificadoresBO fila = new CNotificadoresBO()
                        {
                            IdNotificador = (string)lector["idNotificador"],
                            //ClaveNotificador = (string)lector["ClaveNotificador"],
                            NombreNotificador = (string)lector["nombreNotificador"],
                            //ConcatenadoNotificador = (string)lector["ClaveNotificador"] + "/" + (string)lector["nombreNotificador"]


                        };

                        listNotificadores.Add(fila);


                    }
                    return listNotificadores;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        public CListNotificadores GetListadoNotificadores(string Oficina)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(StrConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("GetCataloNotificadores_LOGICO", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_OHE", Oficina);

                    //Crear conexion para todos los datos
                    CListNotificadores listNotificadores = new CListNotificadores();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {


                        CNotificadoresBO fila = new CNotificadoresBO()
                        {
                            //Convert.ToString(lector["nomEmision"] is DBNull ? "0" : lector["nomEmision"])
                            IdNotificador = (string)lector["idNotificador"],
                            IdClaveOHE = (int)lector["idclaveOHE"],
                            //ClaveNotificador = Convert.ToString(lector["ClaveNotificador"] is DBNull ? "": lector["ClaveNotificador"]),
                            NombreNotificador = (string)lector["nombreNotificador"],
                            //ConcatenadoNotificador = (string)lector["ClaveNotificador"] + "/" + (string)lector["nombreNotificador"]
                        };

                        listNotificadores.Add(fila);


                    }
                    return listNotificadores;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void NuevoNotificador(CNotificadoresBO bo)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(StrConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("NuevoNotificador", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Parametros
                    
                    OrdenSql.Parameters.AddWithValue("@_idNotificador", bo.IdNotificador);
                    OrdenSql.Parameters.AddWithValue("@_claveOHE", bo.IdClaveOHE);
                    //OrdenSql.Parameters.AddWithValue("@_claveNotificador", bo.ClaveNotificador);
                    OrdenSql.Parameters.AddWithValue("@_NombreNotificador", bo.NombreNotificador);
                    OrdenSql.Parameters.AddWithValue("@_status", bo.Status);

                    

                    //Abrir la conexion de base de Datos
                    conn.Open();
                    OrdenSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EditaNotificador(CNotificadoresBO bo)
        {
            try
            {
                using (MySqlConnection conn= new MySqlConnection(StrConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("EditNotificador", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Parametros
                    OrdenSql.Parameters.AddWithValue("@_idNotificador", bo.IdNotificador);
                    //OrdenSql.Parameters.AddWithValue("@_claveNotificador", bo.ClaveNotificador);
                    OrdenSql.Parameters.AddWithValue("@_NombreNotificador", bo.NombreNotificador);

                    //Abrir la conexion de base de Datos
                    conn.Open();
                    OrdenSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void EliminarNotificador(CNotificadoresBO bo)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(StrConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("EliminarNotificador", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Parametros
                    OrdenSql.Parameters.AddWithValue("@_idNotificador", bo.IdNotificador);
                    OrdenSql.Parameters.AddWithValue("@_status", bo.Status);

                    //Abrir la conexion de base de Datos
                    conn.Open();
                    OrdenSql.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
