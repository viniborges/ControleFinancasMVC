﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Financas.Entidades
{
    public class Movimentacao
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public Tipo Tipo { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}