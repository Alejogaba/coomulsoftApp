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
    public class RutasService
    {
        RutasRepository rutasrepository;
        IList<Rutas> rutas;
        SqlConnection conexion;
        public RutasService()
        {
            conexion = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=CoomulsoftApp;Integrated Security=True");
            rutasrepository = new RutasRepository(conexion);

        }
        public string Guardar(Rutas rutas)
        {
            string msg;
            try
            {
                conexion.Open();
                msg = rutasrepository.Insertar(rutas);
                conexion.Close();
                return msg;
            }
            catch (Exception e)
            {
                conexion.Close();
                return "Error en la base de datos" + e.Message.ToString();

            }
        }

        public IList<Rutas> Consultar()
        {
            conexion.Open();
            rutas = new List<Rutas>();
            rutas = rutasrepository.Consultar();
            conexion.Close();
            return rutas;


        }


        public Rutas Buscar(string cod)
        {
            conexion.Open();
           Rutas cd = new Rutas();
            cd = rutasrepository.Buscar(cod);
            conexion.Close();
            return cd;


        }
        public string Eliminar(string origen,string destino)
        {
            string msg;
            try
            {
                conexion.Open();
                msg = rutasrepository.Eliminar(origen, destino);
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
