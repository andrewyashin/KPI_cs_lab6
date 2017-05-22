using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lab6;

namespace Lab6
{
    [Table("employee")]
    public class Employee
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("name")]
        public string name { get; set;}

        [Column("surname")]
        public string surname { get; set; }

        public Position position { get; set; }

        public ICollection<Task> task { get; set; }

        public Employee()
        {
            task = new List<Task>();
        }

    }
}