using System.IO.Compression;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Disney.Models;
using Disney.Data;


namespace Disney.Controllers
{

    public class HomeController : Controller
    {
        private readonly context db = new context();
       
        public IActionResult Index()
        {
            ViewBag.Usuario=db.usuarios.ToList();
            return View();
        }

       
    }
}
