using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectAngular.Category
{
    [Table("Category")]
    public class CategoryPro : IEntity<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }

        public bool IsTransient()
        {
            throw new NotImplementedException();
        }
    }
}
