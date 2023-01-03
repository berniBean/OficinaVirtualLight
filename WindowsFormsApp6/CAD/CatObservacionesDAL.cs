using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.CAD
{
    public class CatObservacionesDAL
    {
        private readonly string StrConn;
        private readonly CatObservacionesBO _catObservaciones;

        public CatObservacionesDAL(CatObservacionesBO catObservaciones)
        {
            _catObservaciones = catObservaciones;
            StrConn = System.Configuration.ConfigurationManager.AppSettings["k1"];
        }

        public CListaCatObservaciones GetCatObservacion()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(StrConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("GetCatObservaciones", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    //Crear conexion para todos los datos
                    CListaCatObservaciones listCatObservaciones = new CListaCatObservaciones();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {


                        CatObservacionesBO fila = new CatObservacionesBO()
                        {
                            IdCatalogo = (int)lector["id"],
                            Observacion = (string)lector["observacion"],
                            Descripcion = (string)lector["descripcion"],
                            ConatenadoObservacion = (int)lector["id"] + " " + (string)lector["observacion"]
                            
                        };

                        listCatObservaciones.Add(fila);
                        
                        
                    }
                    return listCatObservaciones;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
