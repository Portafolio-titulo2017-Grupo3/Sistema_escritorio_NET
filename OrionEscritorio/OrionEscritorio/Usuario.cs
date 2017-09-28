using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrionEscritorio
{
    class Usuario
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string clave { get; set; }
        public string rut_funcionario { get; set; }
        public int perfil_id { get; set; }

        public Usuario()
        {

        }

        
        public Usuario(int idUsuario, string nombre, string clave, string rut_funcionario,int perfil)
        {
            this.idUsuario = 0;
            this.nombre = nombre;
            this.clave = clave;
            this.rut_funcionario = rut_funcionario;
            this.perfil_id = perfil;
        }
    }
}
