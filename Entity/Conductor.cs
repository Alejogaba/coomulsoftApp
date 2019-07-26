using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Conductor : Personas
    {
        public byte[] Imagen { get; set; }
        public string Licencia { get; set; }
        public string Estado_Licencia { get; set; }
        public DateTime Fecha_naciemiento { get; set; }
        public DateTime Fecha_vencimiento_licencia { get; set; }
        public string Email { get; set; }
        public string Vehiculo_asignado { get; set; }

        public Conductor()
        {
        }

        public Conductor(string nombre, string apellido, string identificacion, DateTime fe_na, string telefono,string direccion, byte[] imagen,string licencia,string est_lic,
            DateTime fecha, string email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
            Fecha_naciemiento = fe_na;
            Telefono = telefono;
            Direccion = direccion;
            Imagen = imagen;
            Licencia = licencia;
            Fecha_vencimiento_licencia = fecha;
            Estado_Licencia = est_lic;
            Email = email;
            Vehiculo_asignado = "No asignado";
   
        }

       public void Determinar_estado_Licencia()
        {
            DateTime FechaActual = DateTime.Now;
            if (FechaActual > Fecha_vencimiento_licencia)
            {
                Estado_Licencia = "Vencida";
            }
            else
            {
                Estado_Licencia = "Vigente";
            }
        }

    }
}
