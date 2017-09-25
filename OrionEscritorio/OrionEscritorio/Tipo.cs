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


        public int ingresarTipo(Test test)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();
            OracleCommand orden = new OracleCommand(string.Format("INSERT INTO Tipo(ID,NOMBRE,DESCRIPCION,PERMISO_IDPERMISO,ESTADO_IDESTADO) VALUES('')", test.datoqlo), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }


    }


}
