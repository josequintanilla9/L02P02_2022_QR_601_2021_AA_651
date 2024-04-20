using System.ComponentModel.DataAnnotations;

namespace L02P02_2022_QR_601_2021_AA_651.Models
{
	public class autores
	{
		[Key]
		[Display(Name = "ID")]
		public int id { get; set; }
		[Display(Name = "Autor")]
		public string? autor {  get; set; }
	}
}
