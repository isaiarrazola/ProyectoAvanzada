using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ProyectoAvanzada.Models
{
    public class Sucursal
    {
        [Key]
        public int IdSucursal { get; set; }
        [MaxLength(30, ErrorMessage = "Maximo 30 caracteres")]
        public string Nombre { get; set; }
    }
}