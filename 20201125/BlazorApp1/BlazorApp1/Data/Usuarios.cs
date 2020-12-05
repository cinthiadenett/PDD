using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Usuarios
    {
        public Usuarios() { }

        public Usuarios(int Id, String nombre, String clave)
        {
            this.Id = Id;
            this.nombre = nombre;
            this.clave = clave;

        }

        public int Id { get; set; }
        [MaxLength(50)]
        [MinLength(5)]

       
        
        public String nombre { get; set; }

       
        public String clave { get; set; }
    }
}
    

