using Microsoft.AspNetCore.Mvc;

namespace Foody.PresentationLayer.ViewComponent.AdminLayoutViewComponents;

public class _SideBarLayoutComponentPartial : Microsoft.AspNetCore.Mvc.ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}