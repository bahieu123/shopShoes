using Abp.Application.Services;
using Abp.Domain.Repositories;
using projectAngular.Category;
using projectAngular.Categorys.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectAngular.Categorys
{
    public class CategoryAppService : CrudAppService<CategoryPro, CategoryDto>
    {
        public CategoryAppService(IRepository<CategoryPro, int> repository) : base(repository)
        {
        }
    }
}
