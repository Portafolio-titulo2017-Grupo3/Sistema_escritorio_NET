using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace OrionEscritorio
{
    class TDepartamento
    {
        public int ingresarDepartamento(Departamento depto)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("INSERT INTO TEST VALUES('DATO_QLO') VALUES('{0}')", depto.nombre), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            /*OracleDataAdapter dtaa = new OracleDataAdapter();
            dtaa.InsertCommand = orden;
            dtaa.InsertCommand.ExecuteNonQuery();*/
            return resp;
        }

        

    }
}
