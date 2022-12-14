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
    public virtual async Task<bool> SetSecondModAttAsync(string m)
    {
        return await RequestAsync<bool>(nameof(SetSecondModAttAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), m }
        });
    }
}
