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
    public class ViajesService
    {
        ViajesRepository viajesrepository;
        IList<Viaje> viajes;
        SqlConnection conexion;
        public ViajesService()
        {
            conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=CoomulsoftApp;Integrated Security=True");
            viajesrepository = new ViajesRepository(conexion);

        }
        public string Guardar(Viaje viaje)
        {
            string msg;
            try
            {
                conexion.Open();
                msg = viajesrepository.Insertar(viaje);
                conexion.Close();
                return msg;
            }
            catch (Exception e)
            {
                conexion.Close();
                return "Error en la base de datos" + e.Message.ToString();

            }
        }

        public IList<Viaje> Consultar()
        {
            conexion.Open();
            viajes = new List<Viaje>();
            viajes = viajesrepository.Consultar();
            conexion.Close();
            return viajes;


        }

        public IList<Viaje> Consultar_por_fecha(DateTime fecha)
        {
            conexion.Open();
            viajes = new List<Viaje>();
            viajes = viajesrepository.Consultar_fecha(fecha);
            conexion.Close();
            return viajes;


        }

        public Viaje Buscar_por_cedula(string cod)
        {
            conexion.Open();
            Viaje cd = new Viaje();
            cd = viajesrepository.Buscar_Por_cedula(cod);
            conexion.Close();
            return cd;


        }
        public Viaje Buscar_por_codigo(int cod)
        {
            conexion.Open();
            Viaje cd = new Viaje();
            cd = viajesrepository.Buscar_Por_codigo(cod);
            conexion.Close();
            return cd;


        }

    }
}
