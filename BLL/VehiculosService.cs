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
    public class VehiculosService
    {
        VehiculoRepository vehiculosrepository;
        IList<Vehiculo> vehiculos;
        SqlConnection conexion;
        public VehiculosService()
        {
            conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=CoomulsoftApp;Integrated Security=True");
            vehiculosrepository = new VehiculoRepository(conexion);

        }
        public string Guardar(Vehiculo vehiculo)
        {
            string msg;
            try
            {
                conexion.Open();
                msg = vehiculosrepository.Insertar(vehiculo);
                conexion.Close();
                return msg;
            }
            catch (Exception e)
            {
                conexion.Close();
                return "Error en la base de datos" + e.Message.ToString();

            }
        }

        public string Modificar(Vehiculo vehiculo,string codigo_a_buscar)
        {
            string msg;
            try
            {
                conexion.Open();
                msg = vehiculosrepository.Modificar(vehiculo, codigo_a_buscar);
                conexion.Close();
                return msg;
            }
            catch (Exception e)
            {
                conexion.Close();
                return "Error en la base de datos" + e.Message.ToString();

            }
        }

        public IList<Vehiculo> Consultar()
        {
            conexion.Open();
            vehiculos = new List<Vehiculo>();
            vehiculos = vehiculosrepository.Consultar();
            conexion.Close();
            return vehiculos;


        }

       
        public Vehiculo Buscar(string cod)
        {
            conexion.Open();
            Vehiculo cd = new Vehiculo();
            cd = vehiculosrepository.Buscar(cod);
            conexion.Close();
            return cd;


        }
        public string Eliminar(string codigo)
        {
            string msg;
            try
            {
                conexion.Open();
                msg = vehiculosrepository.Eliminar(codigo);
                conexion.Close();
                return msg;
            }
            catch (Exception ex)
            {
                conexion.Close();
                return ex.Message;
            }

        }
    }
}
