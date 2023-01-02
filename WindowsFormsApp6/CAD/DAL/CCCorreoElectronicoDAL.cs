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
    public class CCCorreoElectronicoDAL
    {
        private readonly string strConn;

        public CCCorreoElectronicoDAL()
        {
            strConn = System.Configuration.ConfigurationManager.AppSettings["k1"];
        }

        public CCCorreoElectronicoDAL(string conn)
        {
            strConn = conn;
        }

        public ListCorreoElectronico GetCorreoElectronico(int IdOhe)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("GetCelular", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_idOhe", IdOhe);
                    //Crear conexion para todos los datos
                    ListCorreoElectronico listCorreo = new ListCorreoElectronico();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        CCorreoElectronicoBO fila = new CCorreoElectronicoBO(
                            (int)lector["idCelular"],
                            (string)lector["numeroCelular"]
                            );
                        listCorreo.Add(fila);
                    }

                    return listCorreo;

                }
            }
            catch (MySqlException e)
            {
                throw new ApplicationException("Error " + e);
            }
        }
    }
}
