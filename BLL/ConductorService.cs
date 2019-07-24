using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using Entity;

namespace BLL
{
    public class ConductorService
    {
        ConductorRepository Conductor;
        IList<Conductor> conductores;
        SqlConnection conexion;
        public ConductorService()
        {
            conexion = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CoomulsoftApp;" +
                                            "Integrated Security=SSPI;MultipleActiveResultSets=True");
            Conductor = new ConductorRepository(conexion);  

        }
        public string Guardar(Conductor conductor)
        {
            try
            {
                conexion.Open();
                Conductor.insertarConductor(conductor);
                conexion.Close();
                return "Se registro el empleado " + conductor.Nombre + " " + conductor.Apellido;
            }
            catch (Exception e)
            {
                conexion.Close();
                return "Error en la base de datos" + e.Message.ToString();
                
            }
        }
    }
}
