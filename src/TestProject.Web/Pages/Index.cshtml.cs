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

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
