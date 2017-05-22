using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab6
{
	[Table("position")]
	public class Position
	{
		[Key]
		[Column("id")]
		public int id { get; set; }

		[Column("name")]
		public string name { get; set; }

		public ICollection<Employee> employee { get; set; }

		public Position()
		{
			employee = new List<Employee>();
		}
	}
}

