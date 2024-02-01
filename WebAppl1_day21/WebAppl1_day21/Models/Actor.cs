using System.ComponentModel.DataAnnotations;

namespace WebAppl1_day21.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
