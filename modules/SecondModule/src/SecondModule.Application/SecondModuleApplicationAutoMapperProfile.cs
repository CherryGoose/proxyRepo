using AutoMapper;

namespace SecondModule;

public class SecondModuleApplicationAutoMapperProfile : Profile
{
    public SecondModuleApplicationAutoMapperProfile()
    {

        CreateMap<SecondNewModuleEntity, SecondNewModuleDto>();
        CreateMap<CreateUpdateSecondNewModuleDto, SecondNewModuleEntity>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
