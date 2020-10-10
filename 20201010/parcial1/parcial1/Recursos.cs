using System;
using System.Collections.Generic;
using System.Text;

namespace parcial1
{

    class Recursos
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}