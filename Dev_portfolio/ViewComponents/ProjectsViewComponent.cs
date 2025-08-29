using Dev_portfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dev_portfolio.ViewComponents
{
    public class ProjectsViewComponent:ViewComponent
    {
 public IViewComponentResult Invoke()
        {
            List<Project> projects = Project.GetProjects().GetRange(0,4);
            return View("_Project", projects);
        }
    }
}
