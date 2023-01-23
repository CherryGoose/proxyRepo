using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities;

namespace SecondModule
{
    public class SecondNewModuleEntity : Entity<string>
    {
        public string Name { get; set; }
        public SecondNewModuleEntity()
        { }
    }
}
