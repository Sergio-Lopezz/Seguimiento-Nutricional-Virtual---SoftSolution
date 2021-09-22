using System;

namespace SeguimientoNutricional.App.Dominio
{
    public class Valoracion
    {
        public int Id {get; set; }

        public int CaloriasConsumidas {get; set; }

        public int Estatura {get; set; }

        public int Peso {get; set; }

        public int Imc {get; set; }

        public DateTime FechaRegistro {get; set; }
    }
}