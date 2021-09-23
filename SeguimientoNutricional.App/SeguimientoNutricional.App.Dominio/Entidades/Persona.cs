using System;

namespace SeguimientoNutricional.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }

        public string DocumentoIdentidad { get; set; }

        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Telefono { get; set; }
        
        public Genero Genero { get; set; }







        

        public string Correo { get; set; }

        public string Ciudad { get; set; }

        public DateTime FechaNacimiento { get; set; }


    }
}