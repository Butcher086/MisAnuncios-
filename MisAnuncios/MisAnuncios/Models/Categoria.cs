﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MisAnuncios.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public virtual List<Anuncio> Anuncios { get; set; }
    }
}