using DAL;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteService
    {
        ClientesRepository clientesrepository;
        IList<Cliente> clientes;
        SqlConnection conexion;
        public ClienteService()
        {
            conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=CoomulsoftApp;Integrated Security=True");
            clientesrepository = new ClientesRepository(conexion);

        }
        public string Guardar(Cliente cliente)
        {
            string msg;
            try
            {
                conexion.Open();
                msg = clientesrepository.Insertar(cliente);
                conexion.Close();
                return msg;
            }
            catch (Exception e)
            {
                conexion.Close();
                return "Error en la base de datos" + e.Message.ToString();

            }
        }

        public IList<Cliente> Consultar_por_codigo(int cod)
        {
            conexion.Open();
            clientes = new List<Cliente>();
            clientes = clientesrepository.Consultar_por_codigo(cod);
            conexion.Close();
            return clientes;


        }


        
    }
}
