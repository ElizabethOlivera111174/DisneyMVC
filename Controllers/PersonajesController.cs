using System.Linq;
using Disney.Data;
using Disney.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Disney.Controllers
{
    [EnableCors("Disney")]

    public class PersonajesController:Controller
    {
        private readonly context db = new context();
        public PersonajesController(){

        }

        public IActionResult Index()
        {
            ViewBag.Personajes= db.Personajes.ToList();
            return View();
        }
        [BindProperty]
        public Personaje personaje{get; set;}
        public IActionResult Guardar()
        {
            if(!ModelState.IsValid){
                return Redirect("/Personaje/");

            }
            db.Personajes.Add(personaje);
            db.SaveChanges();
           
            return RedirectToAction("Index");
        }
         public IActionResult Modificar(int id)
        {
            var Personaje=db.Personajes.Where(x=> x.idPersonaje == id ).SingleOrDefault();
            if (!(Personaje == null))
            {
                 db.Personajes.Update(Personaje);
                 db.SaveChanges();
            }
             return View();
        }
         public IActionResult Eliminar()
        {
            // ViewBag.Personaje=db.Personajes.ToList();
            return View();
        }

       
    }
}
