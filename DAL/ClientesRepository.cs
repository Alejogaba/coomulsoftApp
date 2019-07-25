using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace DAL
{
    public class ClientesRepository
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        IList<Cliente> clientes = new List<Cliente>();


        public ClientesRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }
        public string Insertar(Cliente cliente)
        {
            try
            {
                using (var cmd = Conexion.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Clientes([Codigo viaje],[Identificacion],[Nombres],[Apellidos],[Telefono],[Direccion]" +
                        "VALUES(@codigo_viaje,@id,@nombres,@apellidos,@telefono,@direcion)";


                    cmd.Parameters.Add("@codigo_viaje", SqlDbType.Int).Value = cliente.Codigo_viaje;
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = cliente.Identificacion;
                    cmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = cliente.Nombre;
                    cmd.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = cliente.Apellido;
                    cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = cliente.Telefono;
                    cmd.Parameters.Add("@direcion", SqlDbType.VarChar).Value = cliente.Direccion;


                    int i = cmd.ExecuteNonQuery();

                    return (i > 0) ? "se agrego con exito" : "No se agrego";

                }



            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public IList<Cliente> Consultar_por_codigo(int codigo)
        {

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Clientes Where [Codigo viaje]=@codigo";
                Comando.Parameters.Add("@codigo_viaje", SqlDbType.Int).Value = codigo;
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                   Cliente cliente = new Cliente();
                    cliente = Map(Reader);
                    clientes.Add(cliente);
                }
            }
            return clientes;
        }


       



        public Cliente Map(SqlDataReader reader)
        {
            Cliente cliente = new Cliente();
            cliente.Codigo_viaje = (int)reader["Codigo viaje"];
            cliente.Identificacion = (string)reader["Identificacion"];
            cliente.Nombre = (string)reader["Nombres"];
            cliente.Apellido = (string)reader["Apellidos"];
            cliente.Telefono = (string)reader["Telefono"];
            cliente.Direccion = (string)reader["Direccion"];

            return cliente;
        }
    }
}
