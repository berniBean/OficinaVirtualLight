﻿
using System;
using System.ComponentModel;


namespace WindowsFormsApp6.CAD.BO
{
    public class ListaClistaRequeridos : BindingList<CListaRequeridosBO>
    {
        public static implicit operator ListaClistaRequeridos(CListaRequeridosBO v)
        {
            throw new NotImplementedException();
        }
    }
}
