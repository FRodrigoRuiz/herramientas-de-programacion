using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Libreria.Models;
using Libreria.Services;

namespace Libreria.Controllers;

public class LibroController : Controller
{
    public LibroController()
    {
        
    }

    public IActionResult Index()
    {
        var model = new List<LibroViewModel>();
        model = LibroService.GetAll();

        return View(model);
    }

    public IActionResult Informacion(string codigo){
        var model = LibroService.Get(codigo);

        return View(model);
    }

    public IActionResult Agregar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Agregar(LibroViewModel libroViewModel)
    {
        if (!ModelState.IsValid){
            return RedirectToAction("Agregar");
        }

        LibroService.Add(libroViewModel);

        return RedirectToAction(nameof(Index));
    }
    

    public IActionResult Borrar(string codigo)
    {
        // var libroABorrar = Get(codigo);

        // if (libroABorrar != null){
        //     Libros.Remove(libroABorrar);
        // }
        // Completar luego
        return View();
    }


}