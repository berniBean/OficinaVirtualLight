﻿using System.Windows.Forms;

namespace App_VerFormsAPI.DTO
{
    public class DgEliminarDTO
    {
        public int IdEmision { get; set; }
        public string NomEmision { get; set; }
        public string ReferenciaNumerica { get; set; }

        public ListView ErrorResponse { get; set; }

        public DgEliminarDTO()
        {
                ErrorResponse = new ListView();
        }
    }
}
