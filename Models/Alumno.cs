using System;
using System.Collections.Generic;

#nullable disable

namespace CrudUsuarios.Models
{
    public partial class Alumno
    {
        public int? Id { get; set; }
        public string Nombre { get; set; }
		public string apellidoP{ get; set; }
    }
}
