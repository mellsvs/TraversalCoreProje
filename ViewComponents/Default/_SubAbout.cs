using DataAccsessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        SubAboutManager subAboutManager = new BusinessLayer.Concrete.SubAboutManager(new EfSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values= subAboutManager.TGetList(); 
           
            return View(values);

        }

    }
}
