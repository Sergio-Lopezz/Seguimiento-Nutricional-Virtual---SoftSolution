using System;
using System.ComponentModel.DataAnnotations;

namespace SeguimientoNutricional.App.Dominio
{
    public class Nutricionista : Persona
    {
        //public int Id { get; set; }
        [Required(ErrorMessage = "La Tarjeta Profesional es Obligatorio"), StringLength(20)]
        public string TajertaProfesional {get; set; }

        public Recomendacion Recomendacion { get; set; }

        public HistorialRecomendacion HistorialRecomendacion {get; set; }

        public HistorialValoracion HistorialValoracion {get; set; }
    }
}