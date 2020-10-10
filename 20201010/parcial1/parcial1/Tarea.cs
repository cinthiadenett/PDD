using System;
using System.Collections.Generic;
using System.Text;

namespace parcial1
{
    class Tarea
    {
        public int Id { get; set; }
        public int Titular { get; set; }
        public int TipoId { get; set; }
        public TipoTarea Tipo { get; set; }


        public String Vencimiento { get; set; }
        public int Estimacion { get; set; }
        public int ResponsableId { get; set; }

        public Boolean Estado { get; set; }
    }
    }

