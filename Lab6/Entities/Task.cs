using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lab6
{
    [Table("task")]
    public class Task
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("name")]
        public string name { get; set; }

        [Column("time")]
        public string time { get; set; }

        [Column("priority")]
        public int priority { get; set; }

        [Column("status")]
        public int status { get; set; }

        public Employee employee { get; set; }
    }
}