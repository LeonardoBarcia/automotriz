using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIP_programacionII
{
    public class empleado
    {
        public int legajo { get; set; }
        public string nombre { get; set; }
        public empleado(int legajo, string nombre)
        {
            this.legajo = legajo;
            this.nombre = nombre;
        }

    }
}
