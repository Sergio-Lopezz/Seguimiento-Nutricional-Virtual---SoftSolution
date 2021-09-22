using System;

namespace SeguimientoNutricional.App.Dominio
{
    public class Paciente : Persona
    {    
        //public int Id {get; set; }

        public int Latitud {get; set; }

        public int Longitud {get; set; }   

        public string Direccion {get; set; }

        public Nutricionista Nutricionista {get; set; }

        public Coach Coach {get; set; }

        public Valoracion Valoracion {get; set; }

        public HistorialRecomendacion HistorialRecomendacion {get; set; }

        public HistorialValoracion HistorialValoracion {get; set; }


    }
}