﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prueba_tecnica_net.Models
{
    public class Usuario
    {
        public string Identificador {  get; set; }
        public string User {  get; set; }
        public string Pass {  get; set; }
        public DateTime FechaCreacion { get; set; }

    }
}