using System.Threading.Tasks;
using Volo.Abp.UI.Navigation;

namespace SecondModule.Web.Menus;

public class SecondModuleMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        //Add main menu items.
        context.Menu.AddItem(new ApplicationMenuItem(SecondModuleMenus.Prefix, displayName: "SecondModule", "~/SecondModule", icon: "fa fa-globe"));

        return Task.CompletedTask;
    }
}
