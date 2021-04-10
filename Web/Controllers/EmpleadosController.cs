using System.Collections.Generic;
using System.Threading.Tasks;
using Aplicacion.Empleados;
using Dominio;
using MediatR;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> GetAll()
        {
            
            return Json(new { data = _mediator.Send(new Consulta.ListaEmpleados()).Result });
        }
    }
} 