using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewModule
{
    public class ModuleAppService : NewModuleAppService, IModuleAppService
    {
        private string modAtt;
        public ModuleAppService()
        { 
        
        
        }


        public async Task<bool> SetModAttAsync(string m)
        { 
            modAtt = m;
            
            return true;
        }
    }
}
