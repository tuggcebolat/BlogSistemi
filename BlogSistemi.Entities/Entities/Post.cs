using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSistemi.Entities.Entities
{
    public class Post : IEntity
    {
        public Guid Id { get; set; }
        [StringLength(50), Display(Name = "İçerik Adı")]
        public string Name { get; set; }
        [Display(Name = "İçerik Açıklaması")]
        public string? Description { get; set; }
        public string? Image { get; set; }
        [Display(Name = "Kategori")]
        public Guid CategoryId { get; set; } 
        [Display(Name = "Kategori")]
        public virtual Category? Category { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
