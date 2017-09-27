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
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int permiso_id { get; set; }

        public Motivos()
        {

        }

        public Motivos(int idMotivo, string nombre, string descripcion)
        {
            this.idMotivo = idMotivo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.permiso_id = 0;
        }

    }
}
