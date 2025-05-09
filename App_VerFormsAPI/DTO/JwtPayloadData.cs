using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_VerFormsAPI.DTO
{
    public class JwtPayloadData
    {
        public string email { get; set; }
        public string name { get; set; }
        public string username { get; set; }
        public string zona { get; set; }
        public string role { get; set; }
        public long nbf { get; set; }
        public long exp { get; set; }
        public long iat { get; set; }
        public string iss { get; set; }
    }
}
