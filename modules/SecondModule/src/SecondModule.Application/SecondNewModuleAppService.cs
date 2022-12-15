using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondModule
{
    public class SecondNewModuleAppService: SecondModuleAppService, ISecondNewModuleAppService
    {
        private string modAtt;
        public SecondNewModuleAppService()
        {


        }


        public async Task<bool> SetSecondModAttAsync(string m)
        {
            modAtt = m;

            return true;
        }


    }
}
