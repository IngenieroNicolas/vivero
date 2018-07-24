using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace Vivero.Model
{
    public class Crear : DropCreateDatabaseIfModelChanges<BaseDeDatos>
    {
        protected override void Seed(BaseDeDatos context)
        {
            GetUsuarios().ForEach(u => context.usuarios.Add(u));
            GetPersona().ForEach(p => context.personas.Add(p));
        }

        private List<Persona> GetPersona()
        {
            var personas = new List<Persona>{
            new Persona
            {
                dni = 31997209,
                nombre = "Nicolás",
                apellido = "Hernández"
            }
            };
            return personas;
        }

        private List<usuario> GetUsuarios()
        {
            var usuarios = new List<usuario>
            {
                new usuario
                {
                    user = "admin",
                    contraseña = "21232f297a57a5a743894a0e4a801fc3"
                }
            };
            return usuarios;
        }
    }
}