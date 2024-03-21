using CleanArchitecture.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.CAD.BO
{
    public class COficiosBO  : IControl, IControlOficios, IDirectorio, IFechaOficios, IOficinaHacienda, IZona, IFoliosMultas, IFoliosRequerimientos
    {
        public COficiosBO()
        {

        }

        public COficiosBO(int idOficio, string referencia, string zona, string oHE, int numOficio)
        {
            IdOficio = idOficio;
            IdEmision = referencia;
            Zona = zona;
            OHE = oHE;
            NumOficio = numOficio;
        }

        public COficiosBO(int idOficio, string referencia, string zona, string oHE, int numOficio,DateTime fechaRetro)
         {
             IdOficio = idOficio;
             IdEmision = referencia;
             Zona = zona;
             OHE = oHE;
             NumOficio = numOficio;
            FechaRetro = fechaRetro;

         }

         //OficiosRequerimientos
         public COficiosBO(int idOficio, string referencia, string zona, string oHE, DateTime fechaEmision,
                         int numOficio, DateTime fechaOficios,DateTime fechaRetro,
                         string genero,string jefe, string domicilio, string cp, int total, 
                         int folioInicio, int folioFinal)
         {
             IdOficio = idOficio;
             IdEmision = referencia;
             Zona = zona;
             OHE = oHE;
             FechaEmision = fechaEmision;
             NumOficio = numOficio;
             FechaOficios = fechaOficios;
             FechaRetro = fechaRetro;
             Genero = genero;
             Jefe = jefe;
             Domicilio = domicilio;
             Cp = cp;
             Total = total;
             FolioInicio = folioInicio;
             FolioFinal = folioFinal;

         }

         public COficiosBO(int idOficio, string referencia, string zona, string oHE, DateTime fechaEmision,
                         int numOficio, DateTime fechaOficios, DateTime fechaRetro,
                         string genero, string jefe, string domicilio, string cp,
             int totalMultas,
             int totalMEMultas,
             int inicioME, 
             int finalME,
             int totalMIMultas,
             int inicioMI,
             int finalMI)
         {
             IdOficio = idOficio;
             IdEmision = referencia;
             Zona = zona;
             OHE = oHE;
             FechaEmision = fechaEmision;
             NumOficio = numOficio;
             FechaOficios = fechaOficios;
             FechaRetro = fechaRetro;
             Genero = genero;
             Jefe = jefe;
             Domicilio = domicilio;
             Cp = cp;
             TotalMultas = totalMultas;
             TotalMEMultas = totalMEMultas;
             InicioME = inicioME;
             FinalME = finalME;
             TotalMIMultas = totalMIMultas;
             InicioMI = inicioMI;
             FinalMI = finalMI;
         }




         public int IdOficio { get; set; }
         public string IdEmision { get; set; }

         public int IdOHE { get; set; }
         public int IdTipoOficio { get; set; }
         public int NumOficio { get; set; }
         public string numGuia { get; set; }
         public int IdClaveOHE { get; set; }
         public string Genero { get; set; }
         public string Jefe { get; set; }
         public string Domicilio { get; set; }
         public string Celular { get; set; }
         public string Cp { get; set; }
         public string Telefono { get; set; }
         public string CorreoElectronico { get; set; }
         public int Total { get; set; }
         public int FolioInicio { get; set; }
         public int FolioFinal { get; set; }
         public int TotalMultas { get; set; }
         public int TotalMEMultas { get; set; }
         public int InicioME { get; set; }
         public int FinalME { get; set; }
         public int TotalMIMultas { get; set; }
         public int InicioMI { get; set; }
         public int FinalMI { get; set; }
         public int ClaveZona {get; set; }
         public string Zona {get; set; }
         public int ZonaClave {get; set; }
         public string OHE {get; set; }
         public DateTime FechaRetro { get; set; }
         public DateTime FechaOficios { get; set; }
         public string ClaveReferencia { get; set; }
         public DateTime FechaEmision { get; set; }
         public int Ejerciciofiscal { get; set; }
         public string NombreEmision { get; set; }
         int IControl.IdEmision { get; set; }
    }
}
