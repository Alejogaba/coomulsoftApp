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
        ConductorRepository ConductorRepository; 
        IList<Conductor> conductores;
        SqlConnection conexion;
        public ConductorService()
        {
            conexion = new SqlConnection(@"Data Source=DESKTOP-4TM7H0H\SQLEXPRESS;Initial Catalog=CoomulsoftApp;Integrated Security=True");
            ConductorRepository = new ConductorRepository(conexion);  

        }
        public string Guardar(Conductor conductor)
        {
            string msg;
            try
            {
                conexion.Open();
                msg = ConductorRepository.insertarConductor(conductor);
                conexion.Close();
                return msg;
            }
            catch (Exception e)
            {
                conexion.Close();
                return "Error en la base de datos" + e.Message.ToString();
                
            }
        }

        public IList<Conductor> Consultar()
        {
            string e;
            try
            {
                conexion.Open();
                conductores = new List<Conductor>();
                conductores = ConductorRepository.Consultar();
                conexion.Close();
                return conductores;
            }
            catch (Exception ex)
            {
                conexion.Close();
                e = ex.Message;
                return null;
            }
            
        }
    }
}
