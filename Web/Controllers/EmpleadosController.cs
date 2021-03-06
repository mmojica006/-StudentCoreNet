using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.Empleados;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Web.Controllers
{
    public class EmpleadosController : Controller
    {
        private readonly IMediator _mediator;

        public EmpleadosController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _mediator.Send(new Consulta.ListaEmpleados());
            return View(result);
        }
        [HttpGet]
        public IActionResult Create()
        {
            var genero = _mediator.Send(new ObtenerGenero.Consulta()).Result;
            ViewBag.GenerosEnum = genero;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] 
        public async Task<IActionResult> Create(Nuevo.Ejecuta model)
        {
            if (ModelState.IsValid)
            {
                await  _mediator.Send(model);
                return RedirectToAction(nameof(Index));
            }
           
            return View();
        }


        [HttpGet]
        public  IActionResult GetAll()
        {
            
            return Json(new { data = _mediator.Send(new Consulta.ListaEmpleados()).Result });
        }
    }
} 