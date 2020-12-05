using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Recurso
    {
        public Recurso() { }

        public Recurso(int Id, String Nombre, int usuarioId, Usuarios Usuario)
        {
            this.Id = Id;
            this.Nombre = Nombre;
            this.usuarioId = usuarioId;
            this.Usuario = Usuario;
        }

        public int Id { get; set; }
        public String Nombre { get; set; }
        public int usuarioId { get; set; }
        public Usuarios Usuario { get; set;
    }
}
}
