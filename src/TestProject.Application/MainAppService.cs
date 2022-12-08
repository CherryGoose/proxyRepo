using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    public class MainAppService : IMainAppService
    {
        private string mainAtt;
        public MainAppService()
        {
            mainAtt = "m";
        }


        public async Task<bool> SetMainAttAsync(string m)
        { 
            mainAtt = m;

            return true;
        
        }

    }
}
