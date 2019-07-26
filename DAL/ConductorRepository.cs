using System;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;

namespace DAL
{
    public class ConductorRepository
    {
        private SqlConnection Conexion;
        private SqlDataReader Reader;
        IList<Conductor> conductores = new List<Conductor>();
        

        public ConductorRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }
        public string insertarConductor(Conductor conductor)
        {
            try
            {
                using(var cmd = Conexion.CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO Conductores(Cedula,Nombres,Apellidos,[Fecha nacimiento],Telefono,Email,Direccion,Imagen,Licencia,[Estado licencia],[Fecha vencimiento licencia],[Cuenta bancaria],[Vehiculo asignado])" +
                   "VALUES(@cedula,@nombres,@apellidos,@fecha_nac,@telefono,@email,@direccion,@imagen,@licencia,@est_licencia,@fecha_licencia,@cuenta_bancaria,@vehiculo_a)";

               
                    cmd.Parameters.Add("@cedula", SqlDbType.VarChar).Value = conductor.Identificacion;
                    cmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = conductor.Nombre;
                    cmd.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = conductor.Apellido;
                    cmd.Parameters.Add("@fecha_nac", SqlDbType.Date).Value = conductor.Fecha_naciemiento;
                    cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = conductor.Telefono;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = conductor.Email;
                    cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = conductor.Direccion;
                    cmd.Parameters.Add("@imagen", SqlDbType.Image).Value = conductor.Imagen;
                    cmd.Parameters.Add("@licencia", SqlDbType.VarChar).Value = conductor.Licencia;
                    cmd.Parameters.Add("@est_licencia", SqlDbType.VarChar).Value = conductor.Estado_Licencia;
                    cmd.Parameters.Add("@fecha_licencia", SqlDbType.Date).Value = conductor.Fecha_vencimiento_licencia;
                    cmd.Parameters.Add("@cuenta_bancaria", SqlDbType.VarChar).Value = conductor.Cuenta_bancaria;
                    cmd.Parameters.Add("@vehiculo_a", SqlDbType.VarChar).Value = conductor.Vehiculo_asignado;
       

                    int i = cmd.ExecuteNonQuery();

                    return (i > 0) ? "se agrego con exito" : "NO se agrego la persona";

                }
                
               

            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public string Asignar(string vehiculo,string ced)
        {
           
                using (var Comando = Conexion.CreateCommand())
                {
                    Comando.CommandText = "UPDATE Conductores SET [Vehiculo asignado]=@vehiculo WHERE Cedula=@cedula";


                    Comando.Parameters.Add("@vehiculo", SqlDbType.VarChar).Value = vehiculo;
                    Comando.Parameters.Add("@cedula", SqlDbType.VarChar).Value = ced;


                    int i = Comando.ExecuteNonQuery();

                    return (i > 0) ? "Se asigno correctamente el vehiculo" : "No se pudo asignar";

                }



        }
        public IList<Conductor> Consultar()
        {

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Conductores";
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {
                   
                    Conductor conductor = new Conductor();
                    conductor = Map(Reader);
                    conductores.Add(conductor);
                }
            }
            return conductores;
        }

        

        public IList<Conductor> Filtro(string identificacion)
        {

            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "Select * from Conductores Where Cedula=@cedula";
                Comando.Parameters.Add("@cedula", SqlDbType.VarChar).Value = identificacion;
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    Conductor conductor = new Conductor();
                    conductor = Map(Reader);
                    conductores.Add(conductor);
                }
            }
            return conductores;
        }

        public string Eliminar(string cedula)
        {
                using (var Comando = Conexion.CreateCommand())
                {
                    Comando.CommandText = "DELETE FROM Conductores WHERE Cedula=@cedula";
                    Comando.Parameters.Add("@cedula", SqlDbType.VarChar).Value = cedula;
                    int i = Comando.ExecuteNonQuery();

                    return (i > 0) ? "Se elimino con exito" : "Error al eliminar: No se encontro esa identificacion";
                }
          
            
           
        }

        public Conductor Buscar(string ced)
        {
            Conductor condu = new Conductor();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM Conductores WHERE Cedula=@cedula";
                Comando.Parameters.Add("@cedula", SqlDbType.VarChar).Value = ced;
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {
                   
                    condu = Map(Reader);
                }
            }
            return condu;
        }

        public IList<Conductor> Buscar_por_vehiculo(string veh)
        {
            Conductor condu = new Conductor();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM Conductores WHERE [Vehiculo asignado]=@veh";
                Comando.Parameters.Add("@veh", SqlDbType.VarChar).Value = veh;
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {

                    Conductor conductor = new Conductor();
                    conductor = Map(Reader);
                    conductores.Add(conductor);
                }
            }
            return conductores;
        }


        public IList<Conductor> Filtro_sin_asignar()
        {
            Conductor condu = new Conductor();
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "SELECT * FROM Conductores WHERE [Vehiculo asignado]='No asignado'";
                Reader = Comando.ExecuteReader();

                while (Reader.Read())
                {
                    Conductor conductor = new Conductor();
                    conductor = Map(Reader);
                    conductores.Add(conductor);
                }
            }
            return conductores;
        }
        public string Desasignar(string cedula)
        {
            using (var Comando = Conexion.CreateCommand())
            {
                Comando.CommandText = "UPDATE Conductores SET [Vehiculo asignado]='No asignado' WHERE Cedula=@cedula ";
                Comando.Parameters.Add("@cedula", SqlDbType.VarChar).Value = cedula;
                int i = Comando.ExecuteNonQuery();

                return (i > 0) ? "Desasignado con exito" : "Error al eliminar: No se encontro esa identificacion";
            }


        }
        public Conductor Map(SqlDataReader reader)
        {
            Conductor conductor = new Conductor();
            conductor.Identificacion = (string)reader["Cedula"];
            conductor.Nombre = (string)reader["Nombres"];
            conductor.Apellido = (string)reader["Apellidos"];
            conductor.Fecha_naciemiento = (DateTime)reader["Fecha nacimiento"];
            conductor.Telefono = (string)reader["Telefono"];
            conductor.Email = (string)reader["Email"];
            conductor.Direccion = (string)reader["Direccion"];
            conductor.Imagen = (byte[])reader["Imagen"];
            conductor.Licencia = (string)reader["Licencia"];
            conductor.Estado_Licencia = (string)reader["Estado licencia"];
            conductor.Fecha_vencimiento_licencia = (DateTime)reader["Fecha vencimiento licencia"];
            conductor.Cuenta_bancaria = (string)reader["Cuenta bancaria"];
            conductor.Vehiculo_asignado = (string)reader["Vehiculo asignado"];
            return conductor;
        }
        
    }
}
