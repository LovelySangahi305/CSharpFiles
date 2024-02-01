using System.ComponentModel.DataAnnotations;

namespace WebAppl1_day21.Models
{
    public class Director
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string Name { get; set;}
    }
}
