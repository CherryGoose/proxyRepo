using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace TestProject
{
    public interface IMainAppService: IApplicationService
    {


        public Task<bool> SetMainAttAsync(string m);

    }
}
