using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionEscritorio
{
    class Motivos
    {
        public int idMotivo { get; set; }
        public String descripcion { get; set; }

        public Motivos()
        {

        }

        public Motivos(int idMotivo, String descripcion)
        {
            this.idMotivo = idMotivo;
            this.descripcion = descripcion;
        }

    }
}
