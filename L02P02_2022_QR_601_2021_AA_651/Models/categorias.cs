using System.ComponentModel.DataAnnotations;

namespace L02P02_2022_QR_601_2021_AA_651.Models
{
	public class categorias
	{
		[Key]
		[Display(Name = "ID")]
		public int id { get; set; }
		[Display(Name = "Categoria")]
		public string? categoria { get; set; }
	}
}
