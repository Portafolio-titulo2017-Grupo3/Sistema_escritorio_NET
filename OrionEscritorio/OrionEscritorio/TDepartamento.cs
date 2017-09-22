using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace OrionEscritorio
{
    class TDepartamento
    {
        public int ingresarDepartamento(Departamento depto)
        {
            int resp = 0;
            OracleConnection conexion = Conexion.abrirConexion();//Singleton
            OracleCommand orden = new OracleCommand(string.Format("INSERT INTO TEST(DATO_QLO) VALUES('{0}')", depto.datoqlo), conexion);
            resp = orden.ExecuteNonQuery();
            conexion.Close();
            return resp;
        }

        
        /*public static List<Cliente> listarClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            MySqlConnection conexion = Conexion.abrirConexion();//Singleton
            MySqlCommand orden = new MySqlCommand(string.Format("SELECT * FROM CLIENTE"), conexion);
            MySqlDataReader lector = orden.ExecuteReader();
            while (lector.Read())
            {
                Cliente cliente = new Cliente();
                cliente.rut = lector.GetString(0);
                cliente.nombre = lector.GetString(1);
                cliente.apel = lector.GetString(2);
                cliente.fono = lector.GetString(3);
                lista.Add(cliente);
            }
            return lista;
        }*/
    }
}
