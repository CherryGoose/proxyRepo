using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace SecondModule
{
    public class SecondNewModuleAppService : CrudAppService<
      SecondNewModuleEntity,
       SecondNewModuleDto,
       string,
       PagedAndSortedResultRequestDto,
       CreateUpdateSecondNewModuleDto,
       CreateUpdateSecondNewModuleDto>,
        ISecondNewModuleAppService
    {
        public SecondNewModuleAppService(IRepository<SecondNewModuleEntity, string> repository) : base(repository)
        {


        }
    }
}
