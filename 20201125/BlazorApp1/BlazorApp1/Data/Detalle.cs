using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Detalle
    {
        public Detalle() { }

        public Detalle(int Id, String fecha, String tiempo, int tareaId, Tarea tarea, int recursoId, Recurso recurso)
        {
            this.Id = Id;
            this.fecha = fecha;
            this.tiempo = tiempo;
            this.tareaId = tareaId;
            this.tarea = tarea;
            this.recursoId = recursoId;
            this.recurso = recurso;
        }
        public int Id { get; set; }
        public DateTime fecha { get; set; }
        public String fecha { get; set; }
        public String tiempo { get; set; }
        public int tareaId { get; set; }
        public Tarea tarea { get; set; }
        public int recursoId { get; set; }
        public Recurso recurso { get; set; }
    }
}
