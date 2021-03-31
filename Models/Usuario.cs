using System;
using System.ComponentModel.DataAnnotations;



#nullable disable

namespace CrudUsuarios.Models
{
    public partial class Usuario
    {
        public Guid Id { get; set; }
		
		[Required(ErrorMessage="Favor de ingresar un nombre")]
        public string Nombre { get; set; }
		[Required(ErrorMessage="Favor de ingresar un Apellido paterno")]
        public string ApellidoP { get; set; }
		[Required(ErrorMessage="Favor de ingresar un Apellido materno")]
        public string ApellidoM { get; set; }
		[Required(ErrorMessage="Favor de ingresar un Correo")]
        public string Correo { get; set; }
		[Required(ErrorMessage="Fecha de nacimiennto invalida")]
        public DateTime? FechaNacimeinto { get; set; }
		[Required(ErrorMessage="Favor de ingresar un texto descriptivo")]
        public string AcercaDeMi { get; set; }
    }
}
