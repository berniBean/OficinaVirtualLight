using MySql.Data.MySqlClient;
using System;
using System.Data;
using WindowsFormsApp6.CAD.BO;
using WindowsFormsApp6.CAD.DAL.factories;

namespace WindowsFormsApp6.CAD.DAL
{
    class CCCNombreBimestreDALPLUS : obtenerNombreBimestre
    {
        private readonly string strConn;
        private readonly Login lg = new Login();


        public CCCNombreBimestreDALPLUS()
        {
            strConn = System.Configuration.ConfigurationManager.AppSettings["K1"];
        }

        public CCCNombreBimestreDALPLUS(string conn)
        {
            strConn = conn;
        }



        public ListaCNombreBimestre GetNombreEmisionInforme(string ahno, string periodo )
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("getNombreEmisionPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    if (ahno == "")
                        ahno = "2018";

                    OrdenSql.Parameters.AddWithValue("@_ahno", ahno);
                    if (periodo == "")
                        periodo = "14";
                    OrdenSql.Parameters.AddWithValue("@periodo", periodo);
                    OrdenSql.Parameters.AddWithValue("@OHE", "nada");

                    //Crear conexion para todos los datos
                    ListaCNombreBimestre listNomBim = new ListaCNombreBimestre();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        CNombreBimestreBO fila = new CNombreBimestreBO(

                            Convert.ToString (lector["referenciaNumerica"] is DBNull ? "0": lector["referenciaNumerica"]),
                             Convert.ToString(lector["nomEmision"] is DBNull ? "0" : lector["nomEmision"]) ,
                            Convert.ToDateTime(lector["fechaImpresion"]),
                            Convert.ToInt32(lector["Total"] is DBNull ? null : lector["Total"])
                            );

                        listNomBim.Add(fila);
                    }

                    return listNomBim;

                }
            }
            catch (MySqlException e)
            {
                throw new ApplicationException();
            }

        }





        public ListaCNombreBimestre GetNombreEmision(string periodo, string OHE)
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    MySqlCommand OrdenSql = new MySqlCommand("getNombreEmisionPLUS", conn)
                    {
                        CommandType = CommandType.StoredProcedure
                    };

                    if (periodo == "")
                        periodo = "14";

                    OrdenSql.Parameters.AddWithValue("@_ahno", 0);
                    OrdenSql.Parameters.AddWithValue("@periodo", periodo);
                    if (OHE == "")
                        OHE = "xalapa";
                    OrdenSql.Parameters.AddWithValue("@OHE", OHE);

                    //Crear conexion para todos los datos
                    ListaCNombreBimestre listNomBim = new ListaCNombreBimestre();
                    conn.Open();
                    MySqlDataReader lector = OrdenSql.ExecuteReader();

                    while (lector.Read())
                    {

                        CNombreBimestreBO fila = new CNombreBimestreBO(
                            
                            (string)lector["referenciaNumerica"],
                            (string)lector["nomEmision"],
                            Convert.ToDateTime(lector["fechaImpresion"]),
                            Convert.ToInt32(lector["Total"] is DBNull ? null : lector["Total"])
                            );
                            
                            listNomBim.Add(fila);
                    }

                    return listNomBim;

                }
            }
            catch (MySqlException e)
            {
                throw new ApplicationException("Error " + e);
            }

        }

        public override ListaCNombreBimestre ListNombreBimestre(string periodo, string OHE)
        {
            return GetNombreEmision(periodo, OHE);
        }

        public override ListaCNombreBimestre ListNombreBimestreInforme(string ahno, string periodo)
        {
            return GetNombreEmisionInforme(ahno, periodo);
        }
    }
}
