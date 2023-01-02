using MySql.Data.MySqlClient;
using System;
using System.Data;
using WindowsFormsApp6.Cache;

namespace WindowsFormsApp6.CAD.DAL
{
    class CUsuarioSupDAL
    {
        private readonly string strConn;

        public CUsuarioSupDAL() {
            strConn = System.Configuration.ConfigurationManager.AppSettings["K1"];
        }

        public CUsuarioSupDAL(string conn) {
            strConn = conn;
        }

        public bool IndentificaUsuario(string usuario, string pass) {

           try {
                using (MySqlConnection conn = new MySqlConnection(strConn)) {
                    MySqlCommand OrdenSql = new MySqlCommand("getLoggin", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_usuario", usuario);
                    OrdenSql.Parameters.AddWithValue("@_pass", pass);
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    if (lector.HasRows)
                    {
                        while (lector.Read()) {
                            CUserLoggin.idUser = lector.GetInt32(0);
                            CUserLoggin.nombreSup = lector.GetString(1);
                            CUserLoggin.zonaSupervisor = lector.GetString(2);

                        }


                        return true;
                    }
                    else {
                        return false;
                    }

                    
                    


                }
            } catch (MySqlException err) {
                throw new ApplicationException("Error " + err);
            }

        }



    }
}
