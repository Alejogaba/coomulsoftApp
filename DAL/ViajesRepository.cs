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
    public class ViajesRepository
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        IList<Viaje> viajes = new List<Viaje>();


        public ViajesRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }
        public string Insertar(Viaje viaje)
        {
            try
            {
                using (var cmd = Conexion.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Viajes([Codigo viaje],[Cedula conductor],[Codigo vehiculo],[Fecha salida],[Hora salida],[Ciudad origen],[Ciudad destino])" +
                        "Values(@codigo_viaje,@cedula,@codigo,@fecha_salida,@hora_salida,@origen,@destino)";


                    cmd.Parameters.Add("@codigo_viaje", SqlDbType.Int).Value = viaje.Codigo_viaje;
                    cmd.Parameters.Add("@cedula", SqlDbType.VarChar).Value = viaje.Cedula_conductor;
                    cmd.Parameters.Add("@codigo", SqlDbType.VarChar).Value = viaje.Codigo_vehiculo;
                    cmd.Parameters.Add("@fecha_salida", SqlDbType.Date).Value = viaje.Fecha_salida;
                    cmd.Parameters.Add("@hora_salida", SqlDbType.Date).Value = viaje.Hora_salida;
                    cmd.Parameters.Add("@origen", SqlDbType.VarChar).Value = viaje.Ciudad_origen;
                    cmd.Parameters.Add("@destino", SqlDbType.VarChar).Value = viaje.Ciudad_destino;



                    int i = cmd.ExecuteNonQuery();

                    return (i > 0) ? "se agrego con exito" : "No se agrego";

                }



            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public IList<Viaje> Consultar()
        {
            viajes.Clear();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Viajes";
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    Viaje viaje = new Viaje();
                    viaje = Map(Reader);
                    viajes.Add(viaje);
                }
            }
            return viajes;
        }


        public Viaje Buscar_Por_cedula(string cod)
        {
            viajes.Clear();
            Viaje viaje = new Viaje();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM Viajes WHERE [Cedula conductor]=@codigo";
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = cod;
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    viaje = Map(Reader);
                }
            }
            return viaje;
        }

        public Viaje Buscar_Por_codigo(int cod)
        {
            viajes.Clear();
            Viaje viaje = new Viaje();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM Viajes WHERE [Codigo viaje]=@codigo";
                Comando.Parameters.Add("@codigo", SqlDbType.Int).Value = cod;
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    viaje = Map(Reader);
                }
            }
            return viaje;
        }

        public IList<Viaje> Consultar_fecha(DateTime fecha)
        {
            viajes.Clear();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Viajes where [Fecha salida]=@fecha";
                Comando.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    Viaje viaje = new Viaje();
                    viaje = Map(Reader);
                    viajes.Add(viaje);
                }
            }
            return viajes;
        }




        public Viaje Map(SqlDataReader reader)
        {
            Viaje viaje = new Viaje();
            viaje.Codigo_viaje = (int)reader["Codigo viaje"];
            viaje.Cedula_conductor = (string)reader["Cedula conductor"];
            viaje.Codigo_vehiculo = (string)reader["Codigo vehiculo"];
            viaje.Fecha_salida = (DateTime)reader["Fecha salida"];
            viaje.Hora_salida = (DateTime)reader["Hora salida"];
            viaje.Ciudad_origen = (string)reader["Ciudad origen"];
            viaje.Ciudad_destino = (string)reader["Ciudad destino"];
            return viaje;
        }
    }
}
