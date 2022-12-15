using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace SecondModule
{
    public interface ISecondNewModuleAppService: IApplicationService
    {
        public Task<bool> SetSecondModAttAsync(string m);

    }
}
