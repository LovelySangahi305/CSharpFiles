using System.ComponentModel.DataAnnotations;

namespace WebAppl1_day21.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Lead { get; set; }
        [DataType(DataType.Date)]
        public string Releasedate { get; set; }
    }
}
