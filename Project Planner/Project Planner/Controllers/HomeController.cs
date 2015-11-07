using System.Web.Mvc;
using Project_Planner.Models;
using Data_Access_Layer.Unit_Of_Work;
using Data_Access_Layer.Models;
using System.Collections.Generic;

namespace Project_Planner.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        

        public ActionResult Index()
        {
            return View(new HomeViewModel() { Project = unitOfWork.ProjectRepository.GetAllRecords()});
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