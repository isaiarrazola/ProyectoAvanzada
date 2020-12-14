using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyectoAvanzada.Models
{
    public class Producto
    {
        [Key]
        public int IdProducto { get; set; }
        [MaxLength(30, ErrorMessage = "Maximo 30 caracteres")]
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Existencia { get; set; }

    }
}