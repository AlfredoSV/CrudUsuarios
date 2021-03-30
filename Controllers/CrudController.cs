using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrudUsuarios.Models;

namespace CrudUsuarios.Controllers
{
    public class CrudController : Controller
    {
        private readonly ILogger<CrudController> _logger;
		private sql_ServerContext _sql_serverContext;
		
        public CrudController(ILogger<CrudController> logger,sql_ServerContext sql_serverContext)
        {
            _logger = logger;
			_sql_serverContext =  sql_serverContext;
        }

        public IActionResult Alta()
        {
			
			
			
            return View();
        }

        public IActionResult Listar()
        {
			//Ver información de un usuarios
			ViewBag.alumnos = _sql_serverContext.Alumnos.ToList();
            return View();
        }
		
		public string DescargarPDF()
        {
			//Ver información de un usuarios
			
            return "hola";
        }
		
		[HttpGet("{controller}/Editar/{id}")]
		public string Editar(int id)
        {
			//Ver información de un usuarios
			
            return "Editar" + id;
        }
		
		[HttpGet("{controller}/Eliminar/{id}")]
		public string Eliminar(int id)
        {
			//Ver información de un usuarios
			
            return "Eliminar" + id;
        }

       
    }
}
