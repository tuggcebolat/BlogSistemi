using System.ComponentModel.DataAnnotations;

namespace BlogSistemi.Entities.DTOs.Posts
{
    public class PostDto
    {
        public Guid Id { get; set; }
        [StringLength(50), Display(Name = "İçerik Adı")]
        public string Name { get; set; }
        [Display(Name = "İçerik Açıklaması")]
        public string? Description { get; set; }
        public string? Image { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
