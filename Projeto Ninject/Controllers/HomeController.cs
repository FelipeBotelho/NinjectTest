using Projeto.Ninject.Service.Interfaces;
using System.Web.Mvc;

namespace Projeto_Ninject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;
        private readonly IEnterpriseService _enterpriseService;
        public HomeController(IHomeService homeService, IEnterpriseService enterpriseService)
        {
            _homeService = homeService;
            _enterpriseService = enterpriseService;
        }

        public ActionResult Index()
        {
            var informations = _homeService.GetInformations();
            var enterprise = _enterpriseService.GetInformations();
            var model = new Projeto_Ninject.Models.HomeModel(informations,enterprise);
            return View("Index",model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}