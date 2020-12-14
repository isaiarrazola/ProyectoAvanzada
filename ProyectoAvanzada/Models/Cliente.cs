using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoAvanzada.Models
{
    public class Cliente
    {
		[Key]
		public int IdCliente { get; set; }
		[MaxLength(30, ErrorMessage = "Maximo 30 caracteres")]
		public string Nombre { get; set; }
		public string ApellidoPaterno { get; set; }
		public string ApellidoMaterno { get; set; }
		public string Telefono { get; set; }
		public int Edad { get; set; }

		

	}
}