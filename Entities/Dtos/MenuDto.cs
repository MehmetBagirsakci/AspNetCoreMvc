using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dtos
{
    public class MenuDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ParentId { get; set; }
        public string Url { get; set; }

        public virtual Menu Parent { get; set; }
        public virtual ICollection<Menu> Children { get; set; }
    }
}
