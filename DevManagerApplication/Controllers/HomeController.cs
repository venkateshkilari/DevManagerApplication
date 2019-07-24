using BusinessLogic.Interface.Devops;
using DTO.Implementation.Devops;
using Ninject;
using System.Web.Mvc;

namespace DevManagerApplication.Controllers
{
    public class HomeController : Controller
    {
        private IDevopsService _service;
        public HomeController(IKernel kernal,IDevopsService service)
        {
            _service = service;
        }
        public ActionResult Index(string id="")
        {
            var details = _service.GetServerDetails();
            ViewBag.UserId = id;
            return View(details);
        }
      

        [HttpPost]
        public JsonResult BlockServer(ServerDTO serverDTO)
        {

            _service.BlockServer(serverDTO.Name, serverDTO?.User?.Name);

            return new JsonResult { Data = new { Status = "Success" ,BlockedBy = serverDTO?.User?.Name } };
        }

        [HttpPost]
        public JsonResult ReleaseServer(ServerDTO serverDTO)
        {

            _service.ReleaseServer(serverDTO.Name);

            return new JsonResult { Data = new { Status = "Success", ReleasedBy= serverDTO?.User?.Name } };
        }



    }
}