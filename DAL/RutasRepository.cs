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
    public class RutasRepository
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        IList<Rutas> rutas = new List<Rutas>();


        public RutasRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }
        public string Insertar(Rutas ruta)
        {
            try
            {
                using (var cmd = Conexion.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Rutas([Ciudad origen],[Departamento origen],[Ciudad destino],[Departamento destino],Tarifa)" +
                   "VALUES(@origen,@dptoporigen,@destino,@dptodestino,@tarifa)";


                    cmd.Parameters.Add("@origen", SqlDbType.VarChar).Value = ruta.Ciudad_Origen;
                    cmd.Parameters.Add("@dptoporigen", SqlDbType.VarChar).Value = ruta.Dpto_Origen;
                    cmd.Parameters.Add("@destino", SqlDbType.VarChar).Value = ruta.Ciudad_Destino;
                    cmd.Parameters.Add("@dptodestino", SqlDbType.VarChar).Value = ruta.Dpto_Destino;
                    cmd.Parameters.Add("@Tarifa", SqlDbType.Int).Value = ruta.Tarifa;


                    int i = cmd.ExecuteNonQuery();

                    return (i > 0) ? "se agrego con exito" : "No se agrego";

                }



            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public IList<Rutas> Consultar()
        {
            rutas.Clear();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Rutas";
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    Rutas ruta = new Rutas();
                    ruta = Map(Reader);
                    this.rutas.Add(ruta);
                }
            }
            return rutas;
        }

        public string Eliminar(string origen, string destino)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "DELETE FROM Rutas WHERE (Origen=@origen && Destino=@destino)";
                Comando.Parameters.Add("@origen", SqlDbType.VarChar).Value = origen;
                Comando.Parameters.Add("@destino", SqlDbType.VarChar).Value = origen;
                int i = Comando.ExecuteNonQuery();

                return (i > 0) ? "Se elimino con exito" : "Error al eliminar: No se encontro esa identificacion";
            }



        }

        public Rutas Buscar(string cod)
        {
            rutas.Clear();
            Rutas ruta = new Rutas();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM Rutas WHERE (Origen=@origen && Destino=@destino)";
                Comando.Parameters.Add("@codigo", SqlDbType.VarChar).Value = cod;
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    ruta = Map(Reader);
                }
            }
            return ruta;
        }



        public Rutas Map(SqlDataReader reader)
        {
            Rutas rutas = new Rutas();
            rutas.Ciudad_Origen = (string)reader["Ciudad origen"];
            rutas.Dpto_Origen = (string)reader["Departamento origen"];
            rutas.Ciudad_Destino = (string)reader["Ciudad destino"];
            rutas.Dpto_Destino = (string)reader["Departamento destino"];
            rutas.Tarifa= (int)reader["Tarifa"];

            return rutas;
        }
    }
}
