using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace NewModule
{
    public interface IModuleAppService: IApplicationService
    {
        public Task<bool> SetModAttAsync(string m);

    }
}
