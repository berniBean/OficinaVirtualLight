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

        public CListNotificadores GetListadoNotificadores(string Oficina)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(StrConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("GetCataloNotificadores", conn)
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
                            IdNotificador = (string)lector["idNotificador"],
                            ClaveNotificador = (string)lector["ClaveNotificador"],
                            NombreNotificador = (string)lector["nombreNotificador"]

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
    }
}
