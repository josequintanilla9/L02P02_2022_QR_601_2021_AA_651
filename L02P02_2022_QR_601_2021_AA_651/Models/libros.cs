using System.ComponentModel.DataAnnotations;

namespace L02P02_2022_QR_601_2021_AA_651.Models
{
	public class libros
	{
		[Key] 
		public int id { get; set; }
		[Display(Name ="Nombre")]
		public string? nombre { get; set; }
		[Display(Name = "Descripción")]
		public string? descripcion { get; set; }
		[Display(Name = "Imagen")]
		public string? url_imagen {  get; set; }
		[Display(Name = "ID autor")]
		public int? id_autor {  get; set; }
		[Display(Name = "ID Categoria")]
		public int? id_categoria { get; set; }
		[Display(Name = "Precio")]
		public decimal? precio { get; set; }
		[Display(Name = "Estado")]
		public string? estado { get; set; }
	}
}
