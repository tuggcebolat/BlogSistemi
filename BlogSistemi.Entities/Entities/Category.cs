using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSistemi.Entities.Entities
{
    public class Category:IEntity
    {
        public Guid Id { get; set; }
        [StringLength(50), Display(Name = "Kategori Adı")]
        public string Name { get; set; }
        [Display(Name = "Kategori Açıklaması")]
        public string? Description { get; set; }
        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
       
        public virtual List<Post>? Posts { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
