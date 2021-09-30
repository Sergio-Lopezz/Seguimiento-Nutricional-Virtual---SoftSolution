using System;
using System.ComponentModel.DataAnnotations;

namespace SeguimientoNutricional.App.Dominio
{
    public class Coach : Persona
    {
        //public int Id { get; set; }
        [Required(ErrorMessage = "La Tarjeta Profesional es Obligatorio"), StringLength(20)]

        public string TarjetaProfesional { get; set; }

        [Required(ErrorMessage = "La Especialidad es Obligatorio"), StringLength(15)]
        public string Especialidad { get; set; }


    }

}