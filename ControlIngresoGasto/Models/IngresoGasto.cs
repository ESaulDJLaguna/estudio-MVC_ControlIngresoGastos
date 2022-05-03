using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ControlIngresoGasto.Models
{
	public class IngresoGasto
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[Display(Name = "Nombre de la Categoría")]
		public int CategoriaId { get; set; }

		// La tabla IngresoGasto está relacionada con la tabla Categoria por medio de CategoriaId
		[ForeignKey("CategoriaId")]
		public Categoria Categoria { get; set; }

		[Required]
		[Display(Name = "Fecha")]
		public DateTime Fecha { get; set; }

		[Required]
		[Range(1, 100000)]
		// Imprimirá el dato en formato de moneda (NO el nombre)
		[DisplayFormat(DataFormatString = "{0:C}")]
		// Imprime el nombre del campo
		[Display(Name = "Valor")]
		public double Valor { get; set; }
	}
}
