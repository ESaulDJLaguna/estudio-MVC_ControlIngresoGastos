using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlIngresoGasto.Models
{
	public class Categoria
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "El nombre de la categoría es requerido")]
		[MaxLength(120)]
		[Display(Name = "Nombre de la Categoría")]
		public string NombreCategoria { get; set; }

		[Required(ErrorMessage = "El tipo es requerido. IN: Ingreso | GA: Gasto")]
		[MaxLength(2, ErrorMessage = "Longitud máxima de dos caracteres")]
		[Display(Name = "Tipo")]
		public string Tipo { get; set; } // IN: Ingreso | GA: Gasto

		[Required]
		public bool Estado { get; set; }
	}
}
