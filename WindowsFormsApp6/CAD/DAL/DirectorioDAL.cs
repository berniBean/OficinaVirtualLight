using CleanArchitecture.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.BO.Directorio;

namespace WindowsFormsApp6.CAD.DAL
{
    public class DirectorioDAL
    {
        private readonly string StrConn;
        private DirectorioBO _DirectorioBO;
        public DirectorioDAL(DirectorioBO directorioBO)
        {
            _DirectorioBO = directorioBO;
            StrConn = System.Configuration.ConfigurationManager.AppSettings["k1"];
        }

        public void GetCelular(int IdOhe)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(StrConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("GetAllCelular", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_idClaveOHE", IdOhe);
                    //Crear conexion para todos los datos                   
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {


                        ICelular fila = new CCelularBO()
                        {
                           IdCelular = (int)lector["idCelular"],
                           NumeroCelular = (string)lector["NumeroCelular"]
                        };

                        IDirCelular dirCelularFila = new DirectorioCelular()
                        {
                            CelularAncla = fila
                        };

                        _DirectorioBO.DirCelularsAncla.Add(dirCelularFila);
                    }

                }
            }
            catch (MySqlException)
            {

                throw;
            }
        }

        public void GetDirectorio(int IdOhe)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(StrConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("GetAllDirectorio", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    OrdenSql.Parameters.AddWithValue("@_idClaveOHE", IdOhe);
                    //Crear conexion para todos los datos                   
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        IDirectorio fila = new DirectorioBO()
                        {
                            IdClaveOHE = (int)lector["idClaveOHE"],
                            Genero = (string)lector["Genero"],
                            Jefe = (string)lector["JEFE"],
                            Domicilio = (string)lector["DOMICILIO"],
                            Cp = Convert.ToString( lector["CP"] is DBNull ? null : lector["CP"])
                        };

                        IDirCelular dirCelularFila = new DirectorioCelular()
                        {
                            DirectorioAncla = fila
                        };

                        _DirectorioBO.Directorios.Add(fila);
                        _DirectorioBO.DirCelularsAncla.Add(dirCelularFila);

                    }

                }
            }
            catch (MySqlException)
            {

                throw;
            }
        }
        
        public void UpdateDirectorio(DirectorioBO bo)
        {
            try
            {
                using(MySqlConnection conn = new MySqlConnection(StrConn))
                {
                    MySqlCommand ordenSql = new MySqlCommand("UpdateDirectorio", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    ordenSql.Parameters.AddWithValue("@_Genero", bo.Directorios[0].Genero);
                    ordenSql.Parameters.AddWithValue("@_JEFE", bo.Directorios[0].Jefe);
                    ordenSql.Parameters.AddWithValue("@_DOMICILIO", bo.Directorios[0].Domicilio);
                    ordenSql.Parameters.AddWithValue("@_CP", bo.Directorios[0].Cp);
                    ordenSql.Parameters.AddWithValue("@_idClaveOHE", bo.Directorios[0].IdClaveOHE);


                    conn.Open();
                    ordenSql.ExecuteNonQuery();
                }
            }
            catch (MySqlException err)
            {

                throw new ApplicationException("Error Insert Datos directorio" + err);
            }
        }


        //no modificable
        public void GetOfinas()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(StrConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("GetAllOficinas", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    //OrdenSql.Parameters.AddWithValue("@_idClaveOHE", IdOhe);
                    //Crear conexion para todos los datos                   
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        IOficinaHacienda fila = new OficinaHaciendaBO()
                        {
                            IdClaveOHE = (int)lector["idClaveOHE"],
                            ZonaClave = (int)lector["zonaClave"],
                            OHE = (string)lector["OHE"]
                        };


                        _DirectorioBO.Oficinas.Add(fila);
                    }

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
