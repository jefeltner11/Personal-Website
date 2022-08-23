using System.ComponentModel.DataAnnotations;

namespace Personal_Website.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public string Content { get; set; } = string.Empty;
    }
}
