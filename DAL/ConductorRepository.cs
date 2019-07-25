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
        private SqlCommand cmd;
        public ConductorRepository(SqlConnection conexion)
        {
            Conexion = conexion;
        }
        public string insertarConductor(Conductor conductor)
        {
            try
            {
                string ssql;
                ssql = "INSERT INTO [Conductores]([Cedula],[Nombres],[Apellidos],[Telefono],[Email],[Direccion],[Imagen],[Licencia],[Estado licencia],[Fecha vencimiento licencia],[Cuenta bancaria])" +
                    "VALUES(@cedula,@nombres,@apellidos,@telefono,@email,@direccion,@imagen,@licencia,@est_licencia,@fecha_licencia,@cuenta_bancaria";

                cmd.CommandText = ssql;
                cmd.Parameters.Add("@cedula", SqlDbType.Int).Value = conductor.Identificacion;
                cmd.Parameters.Add("@nombres", SqlDbType.VarChar).Value = conductor.Nombre;
                cmd.Parameters.Add("@apellidos", SqlDbType.VarChar).Value = conductor.Apellido;
                cmd.Parameters.Add("@telefono", SqlDbType.VarChar).Value = conductor.Telefono;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = conductor.Email;
                cmd.Parameters.Add("@direccion", SqlDbType.VarChar).Value = conductor.Direccion;
                cmd.Parameters.Add("@imagen", SqlDbType.VarChar).Value = conductor.Imagen;
                cmd.Parameters.Add("@licencia", SqlDbType.VarChar).Value = conductor.Licencia;
                cmd.Parameters.Add("@est_licencia", SqlDbType.VarChar).Value = conductor.Estado_Licencia;
                cmd.Parameters.Add("@fecha_licencia", SqlDbType.Date).Value = conductor.Fecha_vencimiento_licencia;
                cmd.Parameters.Add("@cuenta_bancaria", SqlDbType.VarChar).Value = conductor.Cuenta_bancaria;
                cmd = new SqlCommand(ssql, Conexion);
                Conexion.Open();
                int i = cmd.ExecuteNonQuery();

                return (i > 0) ? "se agrego la persona" : "NO se agrego la persona";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
