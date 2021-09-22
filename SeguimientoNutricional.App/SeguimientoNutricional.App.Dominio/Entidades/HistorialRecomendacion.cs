using System;

namespace SeguimientoNutricional.App.Dominio
{
    public class HistorialRecomendacion
    {
        public int Id { get; set; }

        public  Recomendacion RegistroRecomendacion { get; set; }
    }
}