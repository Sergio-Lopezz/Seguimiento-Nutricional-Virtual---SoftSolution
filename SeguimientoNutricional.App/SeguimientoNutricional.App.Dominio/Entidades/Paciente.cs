using System;
using System.ComponentModel.DataAnnotations;

namespace SeguimientoNutricional.App.Dominio
{
    public class Paciente : Persona
    {    
        //public int Id {get; set; }

        //[Required(ErrorMessage = "La Latitud es Obligatorio"), StringLength(15)]
        public float Latitud {get; set; }

        //[Required(ErrorMessage = "La Longitud es Obligatorio"), StringLength(15)]
        public float Longitud {get; set; }   

        //[Required(ErrorMessage = "La Direccion es Obligatorio"), StringLength(15)]
        public string Direccion {get; set; }

        public Nutricionista Nutricionista {get; set; }

        public Coach Coach {get; set; }

        public Valoracion Valoracion {get; set; }

        public HistorialRecomendacion HistorialRecomendacion {get; set; }

        public HistorialValoracion HistorialValoracion {get; set; }


    }
}