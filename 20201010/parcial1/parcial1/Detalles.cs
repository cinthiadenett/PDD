using System;
using System.Collections.Generic;
using System.Text;

namespace parcial1
{
    class Detalles
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Tiempo { get; set; }
        public int TareaId { get; set; }
        public Tarea Tarea { get; set; }
        public int RecursoId { get; set; }
        public Recursos Recurso { get; set; }
    }
}
