using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using NewModule;
using SecondModule;

namespace TestProject.Web.Pages;

public class IndexModel : TestProjectPageModel
{

    private IModuleAppService _moduleAppService;
    ISecondNewModuleAppService _secondNewModuleAppService;
    private IMainAppService _mainAppService;
    public IndexModel(IModuleAppService moduleAppService, 
        IMainAppService mainAppService, 
        ISecondNewModuleAppService secondNewModuleAppService)
    {
        _moduleAppService = moduleAppService;
        _secondNewModuleAppService = secondNewModuleAppService;
        _mainAppService = mainAppService;
    }
    public async void OnGet()
    {


        var module = await _moduleAppService.SetModAttAsync("1");
        var secondModule = await _secondNewModuleAppService.SetSecondModAttAsync("2");
        var main = await _mainAppService.SetMainAttAsync("m");
    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
