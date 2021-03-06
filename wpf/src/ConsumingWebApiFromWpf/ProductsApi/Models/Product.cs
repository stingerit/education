﻿namespace ProductsApi.Models
{
	using System.ComponentModel.DataAnnotations;

	public class Product
	{
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		public string Name { get; set; }

		[Required]
		[Display(Name = "Category")]
		public int CategoryId { get; set; }

		public decimal Price { get; set; }

		public Category Category { get; set; }
	}
}