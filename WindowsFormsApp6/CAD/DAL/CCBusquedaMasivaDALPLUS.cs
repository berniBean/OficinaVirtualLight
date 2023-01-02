using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6.CAD.DAL
{
    public class CCBusquedaMasivaDALPLUS : obtenerBusquedaMasiva
    {

        private readonly string strConn;



        public CCBusquedaMasivaDALPLUS()
        {
            strConn = System.Configuration.ConfigurationManager.AppSettings["k1"];
        }

        public CCBusquedaMasivaDALPLUS(string conn)
        {
            strConn = conn;
        }

        public override void BusquedaMasiva(string bo)
        {
            CrearListaBusquedaMasiva(bo);
        }

        public void CrearListaBusquedaMasiva(string bo)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("crearListaMasiva", conn)
                    {
                        CommandType = CommandType.StoredProcedure

                    };

                    //parametros

                    
                    OrdenSql.Parameters.AddWithValue("@_miembroLista", bo);
                    conn.Open();
                    OrdenSql.ExecuteNonQuery();

                    

                }
            }
            catch (MySqlException err)
            {

                throw new ApplicationException("Error Insert Fechas" + err);
            }

        }

        private void insetarRegistro(string v)
        {
            throw new NotImplementedException();
        }
    }

    
}
