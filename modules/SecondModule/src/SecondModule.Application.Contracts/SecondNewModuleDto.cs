using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace SecondModule
{
    public class SecondNewModuleDto : EntityDto<string>
    {
        public string Name { get; set; }
    }
}
