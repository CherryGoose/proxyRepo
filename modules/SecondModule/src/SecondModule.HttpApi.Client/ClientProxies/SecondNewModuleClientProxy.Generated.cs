// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using SecondModule;

// ReSharper disable once CheckNamespace
namespace SecondModule.ClientProxies;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(ISecondNewModuleAppService), typeof(SecondNewModuleClientProxy))]
public partial class SecondNewModuleClientProxy : ClientProxyBase<ISecondNewModuleAppService>, ISecondNewModuleAppService
{
    public virtual async Task<SecondNewModuleDto> CreateAsync(CreateUpdateSecondNewModuleDto input)
    {
        return await RequestAsync<SecondNewModuleDto>(nameof(CreateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(CreateUpdateSecondNewModuleDto), input }
        });
    }

    public virtual async Task<SecondNewModuleDto> UpdateAsync(string id, CreateUpdateSecondNewModuleDto input)
    {
        return await RequestAsync<SecondNewModuleDto>(nameof(UpdateAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), id },
            { typeof(CreateUpdateSecondNewModuleDto), input }
        });
    }

    public virtual async Task DeleteAsync(string id)
    {
        await RequestAsync(nameof(DeleteAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), id }
        });
    }

    public virtual async Task<SecondNewModuleDto> GetAsync(string id)
    {
        return await RequestAsync<SecondNewModuleDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), id }
        });
    }

    public virtual async Task<PagedResultDto<SecondNewModuleDto>> GetListAsync(PagedAndSortedResultRequestDto input)
    {
        return await RequestAsync<PagedResultDto<SecondNewModuleDto>>(nameof(GetListAsync), new ClientProxyRequestTypeValue
        {
            { typeof(PagedAndSortedResultRequestDto), input }
        });
    }
}
