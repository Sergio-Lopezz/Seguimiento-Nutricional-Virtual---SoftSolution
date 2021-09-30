using System;
using System.ComponentModel.DataAnnotations;


namespace SeguimientoNutricional.App.Dominio
{
    public class Persona
    {
        public int Id { get; set; }

        //[Required(ErrorMessage = "El Documento de Identidad es Obligatorio"), StringLength(15)]
        public string DocumentoIdentidad { get; set; }

        [Required(ErrorMessage = "El Nombre es Obligatorio"), StringLength(15)]
        public string Nombre { get; set; }

        //[Required(ErrorMessage = "El Apellido es Obligatorio"), StringLength(15)] 
        public string Apellido { get; set; }

        //[Required(ErrorMessage = "El Telefono es Obligatorio"), StringLength(15)]
        public string Telefono { get; set; }
        
        //[Required(ErrorMessage = "El Genero es Obligatorio")]
        public Genero Genero { get; set; }

        //[Required(ErrorMessage = "El Correo es Obligatorio"), StringLength(30)]
        public string Correo { get; set; }

        //[Required(ErrorMessage = "La Ciudad es Obligatorio"), StringLength(30)]
        public string Ciudad { get; set; }

        //[DataType(DataType.Date)]
        //[Display(Name = "Fecha De Nacimiento")]
        public DateTime FechaNacimiento { get; set; }


    }
}