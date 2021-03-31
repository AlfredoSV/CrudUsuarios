using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CrudUsuarios.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

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

		[HttpGet]
        public IActionResult Alta()
        {
			ViewBag.exito = false;
			
			
            return View();
        }
		
		[HttpPost]
		public IActionResult Alta(Usuario model)
        {
			
			
			if(!ModelState.IsValid){
				ViewBag.exito = false;
				return View("Alta",model);
				
			}
			ViewBag.exito = true;
			
			ModelState.Clear();
		
			return View();
			        
        }

		[Route("{controller}/{action}/{desde}/{opcion}")]
        public IActionResult Listar(int desde =0, int opcion=1)
        {
			
			
			ViewBag.totalR = _sql_serverContext.Usuarios.Count();
			ViewBag.totalP = Math.Ceiling((double)ViewBag.totalR /(double)5);
			
			int hasta = 0;
			ViewBag.re = true;
			ViewBag.av = true;
		
			
			if(opcion == 1 && desde != ViewBag.totalR ){
			
				hasta = desde + 5;
			}else if(opcion == -1 && desde >= 1){
				
				hasta = desde;
				desde-=5;	
				
			
			}
			
			/*if(desde == 0 && opcion == -1){
				desde = 0;
				hasta = 5;
				
				
	
	
			}*/
			
			if(desde == 0 && (opcion == 1 || opcion == -1)){
				ViewBag.re = false;
									
			}
			
			
			
			if(desde+5 >= ViewBag.totalR  && opcion == 1){
				ViewBag.av = false;
							
			}
			
	
			
			/*if(desde == ViewBag.totalR ){
			
				desde = desde - 5;	
				hasta = ViewBag.totalR ;	
			
			
			}
			*/
			
			ViewBag.alumnos =  _sql_serverContext.Usuarios.FromSqlRaw($"EXECUTE dbo.paginacion {desde+1}, {hasta}").ToList();
			
		
		
				
				ViewBag.desde = hasta;
			
				ViewBag.hasta = desde;
				
			
			ViewBag.pag = ViewBag.desde/5;
			
			

			
		
			
			//ViewBag.alumnos = _sql_serverContext.Usuarios.ToList();
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
