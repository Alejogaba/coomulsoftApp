using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    class Credenciales
    {
        public String Usuario { get; set; }
        public String Contrasena { get; set; }

        public Credenciales(string usuario, string contrasena)
        {
            Usuario = usuario;
            Contrasena = contrasena;
        }
    }
}
