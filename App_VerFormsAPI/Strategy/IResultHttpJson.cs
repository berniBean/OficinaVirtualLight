using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_VerFormsAPI.Strategy
{
    public interface IResultHttpJson<T>
    {
        List<T> ResponseAsync(RestResponse respuesta);
    }
}
