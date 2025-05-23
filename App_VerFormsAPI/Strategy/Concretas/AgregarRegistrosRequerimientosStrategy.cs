﻿using App_VerFormsAPI.ResponseHttp;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_VerFormsAPI.Strategy.Concretas
{
    public class AgregarRegistrosRequerimientosStrategy : IResultHttpStrategy
    {
        public void ProcesarRespuesta(RestResponse respuesta, ListView listView)
        {
            if (respuesta.IsSuccessStatusCode)
            {
                listView.Items.Add(new ListViewItem(new[] { "Agregar requerimientos:", $"Exito, transacciones totales:{respuesta.Content.ToString()}" }));
            }
            else
            {
                var res = new ErrorResponse
                {
                    StatusCode = (int)respuesta.StatusCode,
                    Message = respuesta.ErrorMessage ?? respuesta.StatusDescription
                };
                listView.Items.Add(new ListViewItem(new[] { "Agregar requerimientos:", $"Error:{res.Message}" }));
            }
        }
    }
}
