﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_VerFormsAPI.DTO
{
    public class ApiLoginResponse
    {
        public string Id { get; set; }
        public string Token { get; set; }
        public bool Admin { get; set; }
    }
}
