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
    public class VehiculoRepository
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        IList<Vehiculo> vehiculos = new List<Vehiculo>();


        public VehiculoRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }
        public string Insertar(Vehiculo vehiculo)
        {
            try
            {
                using (var cmd = Conexion.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Vehiculos(Imagen,Codigo,Modelo,[Placa vehiculo],[Año modelo],[Tipo vehiculo],[Capacidad pasajeros],[Capacidad maletero])" +
                   "VALUES(@imagen,@codigo,@modelo,@placa,@anio,@tipo,@pasajeros,@maletero)";

                    cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = vehiculo.Imagen;
                    cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = vehiculo.Codigo;
                    cmd.Parameters.Add("@modelo", SqlDbType.VarChar).Value = vehiculo.Modelo;
                    cmd.Parameters.Add("@placa", SqlDbType.VarChar).Value = vehiculo.Placa_Vehiculo;
                    cmd.Parameters.Add("@anio", SqlDbType.VarChar).Value = vehiculo.Anio_Modelo;
                    cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = vehiculo.Tipo_vehiculo;
                    cmd.Parameters.Add("@pasajeros", SqlDbType.Int).Value = vehiculo.Capacidad_pasajeros;
                    cmd.Parameters.Add("@maletero", SqlDbType.Float).Value = vehiculo.Capacidad_maletero;
                   

                    int i = cmd.ExecuteNonQuery();

                    return (i > 0) ? "se agrego con exito" : "No se agrego";

                }



            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }
        public string Modificar(Vehiculo vehiculo,string codigo)
        {
            try
            {
                using (var cmd = Conexion.CreateCommand())
                {
                    cmd.CommandText = "UPDATE Vehiculos Imagen=@imagen,Codigo=@codigo,Modelo=@modelo,[Placa vehiculo]=@placa,[Año modelo]=@anio," +
                        "[Tipo vehiculo]=@tipo,[Capacidad pasajeros]=@pasajeros,[Capacidad maletero]=@maletero WHERE Codigo=@codigobuscado";

                    cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = vehiculo.Imagen;
                    cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = vehiculo.Codigo;
                    cmd.Parameters.Add("@modelo", SqlDbType.VarChar).Value = vehiculo.Modelo;
                    cmd.Parameters.Add("@placa", SqlDbType.VarChar).Value = vehiculo.Placa_Vehiculo;
                    cmd.Parameters.Add("@anio", SqlDbType.VarChar).Value = vehiculo.Anio_Modelo;
                    cmd.Parameters.Add("@tipo", SqlDbType.VarChar).Value = vehiculo.Tipo_vehiculo;
                    cmd.Parameters.Add("@pasajeros", SqlDbType.Int).Value = vehiculo.Capacidad_pasajeros;
                    cmd.Parameters.Add("@maletero", SqlDbType.Float).Value = vehiculo.Capacidad_maletero;
                    cmd.Parameters.Add("@codigobuscado", SqlDbType.VarChar).Value = codigo;

                    int i = cmd.ExecuteNonQuery();

                    return (i > 0) ? "se modifico con exito" : "No se pudo modificar";

                }



            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }
        public IList<Vehiculo> Consultar()
        {
            vehiculos.Clear();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Vehiculos";
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    Vehiculo vehiculo = new Vehiculo();
                    vehiculo = Map(Reader);
                    vehiculos.Add(vehiculo);
                }
            }
            return vehiculos;
        }

        public string Eliminar(string codigo)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "DELETE FROM Vehiculos WHERE Codigo=@codigo";
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = codigo;
                int i = Comando.ExecuteNonQuery();

                return (i > 0) ? "Se elimino con exito" : "Error al eliminar: No se encontro esa identificacion";
            }



        }

        public Vehiculo Buscar(string cod)
        {
            vehiculos.Clear();
            Vehiculo condu = new Vehiculo();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM Vehiculos WHERE Codigo=@codigo";
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = cod;
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    condu = Map(Reader);
                }
            }
            return condu;
        }



        public Vehiculo Map(SqlDataReader reader)
        {
            Vehiculo vehiculo = new Vehiculo();
            vehiculo.Imagen = (byte[])reader["Imagen"];
            vehiculo.Codigo = (string)reader["Codigo"];
            vehiculo.Modelo = (string)reader["Modelo"];
            vehiculo.Placa_Vehiculo = (string)reader["Placa vehiculo"];
            vehiculo.Anio_Modelo = (string)reader["Año modelo"];
            vehiculo.Tipo_vehiculo = (string)reader["Tipo vehiculo"];
            vehiculo.Capacidad_pasajeros = (int)reader["Capacidad pasajeros"];
           
      


            return vehiculo;
        }
    }
}
