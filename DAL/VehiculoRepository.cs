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
                    cmd.CommandText = "INSERT INTO Vehiculos(Imagen,Codigo,[Placa vehiculo],[Año modelo],[Tipo vehiculo],[Capacidad pasajeros],[Capacidad maletero],[Consumo gasolina por km])" +
                   "VALUES(@cedula,@nombres,@apellidos,@fecha_nac,@telefono,@email,@direccion,@imagen,@licencia,@est_licencia,@fecha_licencia,@cuenta_bancaria,@vehiculo_a)";


                    cmd.Parameters.Add("@placa", SqlDbType.VarChar).Value = vehiculo.Placa_Vehiculo;

                 


                    int i = cmd.ExecuteNonQuery();

                    return (i > 0) ? "se agrego con exito" : "NO se agrego la persona";

                }



            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public IList<Vehiculo> Consultar()
        {

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Conductores";
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    Vehiculo conductor = new Vehiculo();
                    conductor = Map(Reader);
                    vehiculos.Add(conductor);
                }
            }
            return vehiculos;
        }

        public string Eliminar(string cedula)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "DELETE FROM Conductores WHERE Cedula=@cedula";
                Comando.Parameters.Add("@cedula", SqlDbType.Int).Value = cedula;
                int i = Comando.ExecuteNonQuery();

                return (i > 0) ? "Se elimino con exito" : "Error al eliminar: No se encontro esa identificacion";
            }



        }

        public Vehiculo Buscar(string ced)
        {
            Vehiculo condu = new Vehiculo();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM Conductores WHERE Cedula=@cedula";
                Comando.Parameters.Add("@cedula", SqlDbType.Int).Value = ced;
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
            Vehiculo conductor = new Vehiculo();
            conductor.Placa_Vehiculo = (string)reader["Placa vehiculo"];
            
            return conductor;
        }
    }
}
