﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WindowsFormsApp6.CAD.BO;

namespace WindowsFormsApp6.CAD.DAL.factories
{
    public abstract class obtenerTableroSup
    {

        public abstract CListaTableroAdmin GetVanceEmision(int emision, int idSup);
        
        public abstract Task<List<CTableroAdminBO>> GetListadoCompleto(int emision, string idSup);
        public abstract Task<CListaTableroAdmin> GetEjerciciosFisales();
        public abstract Task<CListaTableroAdmin> GetEjerciciosMultasFisales();
        public abstract Task<CListaTableroAdmin> TableroMultasSupervisor(int supervisor, int ejercicio);
        public abstract Task <CListaTableroAdmin> Tablero(int año);
        public abstract Task<CListaTableroAdmin> TableroPLUS(int año);
        public abstract CListaTableroAdmin TableroEjercicioFiscal();
        public abstract Task<CListaTableroAdmin> TableroMultasAdmin(int año);
        public abstract Task<CListaTableroAdmin> GetAvanceMultasAdmin(int emision, int idSup);
        public abstract Task<ListaClistaRequeridos> GetTableroMultasGENAdmin(int emision, int idSup);
        

    }
}
