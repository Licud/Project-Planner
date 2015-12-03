using System.Web.Mvc;
using Project_Planner.Models;
using Data_Access_Layer.Unit_Of_Work;
using System.Web.Script.Serialization;
using Data_Access_Layer.Models;
using System;
using System.Collections.Generic;
using System.Web.Helpers;
using Newtonsoft.Json;

namespace Project_Planner.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private JavaScriptSerializer jsSerial = new JavaScriptSerializer();

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

        [HttpPost]
        public JsonResult AddProject(string projectdata)
        {

            var deserializedData = JsonConvert.DeserializeObject<Project>(projectdata);

            Project newProject = new Project()
            {
                strName = deserializedData.strName,
                strAim = deserializedData.strAim,
                strDetails = deserializedData.strDetails,
                strStatus = "Ongoing",
                strCurrentVersion = "v1",
                dtmCreatedDate = DateTime.Now.Date,
                dtmProjectedFinishedDate = Convert.ToDateTime(deserializedData.dtmProjectedFinishedDate)
            };

            return Json(new { projectName=newProject.strName });
        }
    }
}