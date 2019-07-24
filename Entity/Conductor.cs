using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    public class Conductor : Personas
    {
        public string Imagen { get; set; }
        public string Licencia { get; set; }
        public string Estado_Licencia { get; set; }
        public DateTime Fecha_vencimiento_licencia { get; set; }
        public string Email { get; set; }
        public string Cuenta_bancaria { get; set; }


        public Conductor()
        {
        }

        public Conductor(string nombre, string apellido, string identificacion, string telefono,string direccion, string imagen,string licencia,
            DateTime fecha, string email,string bank)
        {
            Nombre = nombre;
            Apellido = apellido;
            Identificacion = identificacion;
            Telefono = telefono;
            Direccion = direccion;
            Imagen = imagen;
            Licencia = licencia;
            Fecha_vencimiento_licencia = fecha;
            Email = email;
            Cuenta_bancaria = bank;
   
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
