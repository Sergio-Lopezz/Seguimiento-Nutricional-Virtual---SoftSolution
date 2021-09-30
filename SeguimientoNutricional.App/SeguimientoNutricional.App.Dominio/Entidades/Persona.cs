using System;
using System.ComponentModel.DataAnnotations;


namespace SeguimientoNutricional.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El Documento de Identidad es Obligatorio"), StringLength(15)]
        public string DocumentoIdentidad { get; set; }

        [Required(ErrorMessage = "El Nombre es Obligatorio"), StringLength(15)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es Obligatorio"), StringLength(15)] 
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El Telefono es Obligatorio"), StringLength(15)]
        public string Telefono { get; set; }
        
        public Genero Genero { get; set; }

        public string Correo { get; set; }

        public string Ciudad { get; set; }

        public DateTime FechaNacimiento { get; set; }


    }
}