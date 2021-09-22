using System;

namespace SeguimientoNutricional.App.Dominio
{
    public class Nutricionista : Persona
    {
        //public int Id { get; set; }
        public string TajertaProfesional {get; set; }

        public Recomendacion Recomendacion { get; set; }

        public HistorialRecomendacion HistorialRecomendacion {get; set; }

        public HistorialValoracion HistorialValoracion {get; set; }
    }
}