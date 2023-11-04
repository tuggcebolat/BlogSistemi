using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSistemi.Entities.Entities
{
    public interface IEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }

    }
}
