using System.ComponentModel.DataAnnotations;

namespace enthusiastic.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string? Autor { get; set; }
        public string Content { get; set; }
  
    }
}
