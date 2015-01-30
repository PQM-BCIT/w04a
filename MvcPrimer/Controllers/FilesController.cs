using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPrimer.Controllers
{
    public class FilesController : Controller
    {
        // GET: Files
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            DirectoryInfo dir = new DirectoryInfo(Server.MapPath("/files"));
            List<string> files = new List<string>();
            files = Directory.GetFiles(dir.ToString(), "*.txt").ToList();

            return View(files);
        }
    }
}