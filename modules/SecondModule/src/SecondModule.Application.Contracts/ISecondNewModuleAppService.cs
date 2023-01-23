using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace SecondModule
{
    public interface ISecondNewModuleAppService:ICrudAppService<
       SecondNewModuleDto,
       string,
       PagedAndSortedResultRequestDto,
       CreateUpdateSecondNewModuleDto,
       CreateUpdateSecondNewModuleDto>
        {

    }
}
