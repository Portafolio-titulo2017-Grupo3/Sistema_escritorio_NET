using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrionEscritorio
{
    class Perfil
    {
        public int idPerfil { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public int usuario_id { get; set; }

        public Perfil()
        {

        }

        public Perfil(int idPerfil, string nombre, string descripcion)
        {
            this.idPerfil = idPerfil;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.usuario_id = 0;
        }
    }
}
