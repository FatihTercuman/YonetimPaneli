using System.ComponentModel.DataAnnotations;

namespace Core.Concrete.DTTOs
{
    public class NewPostDto
    {
        [Required]
        public string Title { get; set; }
        [Required,DataType(DataType.MultilineText)]
        public string Content { get; set; }
        public string AuthorId{ get; set; }

        [Required,Display(Name ="Cover Image")]
        public string CoverImageUrl { get; set; }
    }
}
