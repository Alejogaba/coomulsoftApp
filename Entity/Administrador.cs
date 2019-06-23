using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
    class Administrador
    {
        public String Usuario { get; set; }
        public String Contrasena { get; set; }

        public Administrador(string usuario, string contrasena)
        {
            Usuario = usuario;
            Contrasena = contrasena;
        }
    }
}
