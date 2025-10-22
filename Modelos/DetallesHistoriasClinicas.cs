﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class DetallesHistoriasClinicas
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public HistoriasClinicas historiaClinica { get; set; }
        public Medicos medico { get; set; }
        public Eventos tipoEvento { get; set; }
    }
}
