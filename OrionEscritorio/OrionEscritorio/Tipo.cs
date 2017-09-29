using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionEscritorio
{
    class Tipo
    {
        public int idTipo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int permiso_id { get; set; }

        public Tipo()
        {

        }

        public Tipo(int idTipo, string nombre, string descripcion, int permiso_id)
        {
            this.idTipo = idTipo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.permiso_id = permiso_id;
        }
    }


}
