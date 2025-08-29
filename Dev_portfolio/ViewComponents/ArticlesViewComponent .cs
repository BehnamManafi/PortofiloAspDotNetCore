using Dev_portfolio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dev_portfolio.ViewComponents
{
    public class ArticlesViewComponent:ViewComponent
    {
 public IViewComponentResult Invoke()
        {
            List<Article> articles = Article.GetArticles().GetRange(0,3);
            return View("_Article", articles);
        }
    }
}
