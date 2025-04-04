using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loggin
{
    internal class Usuario
    {
        private static List<Usuario> usuarios = new List<Usuario>
        {
            new Usuario{NombreUsuario = "Admin", Contrasenia = "1234"},
            new Usuario{NombreUsuario = "Juan", Contrasenia = "3333"},
            new Usuario{NombreUsuario = "Adrian", Contrasenia = "2548"}
        };
        public Usuario(string nombreUsuario, string contrasenia)
        {
            NombreUsuario = nombreUsuario;
            Contrasenia = contrasenia;
        }
        public List<Usuario> ObtenerUsuario()
        { 
            return usuarios; 
        }
        public Usuario() { }
        public string NombreUsuario { get; set; }
        public string Contrasenia { get;set; }
    }
}
