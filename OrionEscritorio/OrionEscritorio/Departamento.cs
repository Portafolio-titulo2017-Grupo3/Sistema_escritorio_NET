using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionEscritorio
{
    class Departamento
    {
        public int idDepto { get; set; }
        public string nombre { get; set; }
        public string responsable { get; set; }

        public Departamento()
        {

        }
        public Departamento(int idDepto, string nombre, string responsable)
        {
            this.idDepto = idDepto;
            this.nombre = nombre;
            this.responsable = responsable;
        }

    }
}
