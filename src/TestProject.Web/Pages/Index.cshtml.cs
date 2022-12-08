using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using NewModule;

namespace TestProject.Web.Pages;

public class IndexModel : TestProjectPageModel
{

    private IModuleAppService _moduleAppService;
    public IndexModel(IModuleAppService moduleAppService) 
    {
    _moduleAppService = moduleAppService;
    }
    public async void OnGet()
    {
       var res =await _moduleAppService.SetModAttAsync("1");
    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
