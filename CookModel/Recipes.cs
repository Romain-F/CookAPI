using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CookModel
{
	public class Recipes
	{
		public int Id { get; set; }

		[Required]
		[StringLength(60, MinimumLength = 3)]
		public string Title { get; set; }

		[Required]
		public int PrepTime { get; set; }

		[Required]
		public int CookTime { get; set; }

		[Required]
		public int Image { get; set; }

		[DataType(DataType.Date)]
		public DateTime ReleaseDate { get; set; }
	}
}
