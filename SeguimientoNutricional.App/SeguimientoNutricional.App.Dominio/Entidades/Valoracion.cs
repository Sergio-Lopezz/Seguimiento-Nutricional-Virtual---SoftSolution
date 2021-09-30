using System;
using System.ComponentModel.DataAnnotations;

namespace SeguimientoNutricional.App.Dominio
{
    public class Valoracion
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese Calorias")]
        public float CaloriasConsumidas { get; set; }

        [Required(ErrorMessage = "Ingrese Estatura")]
        public float Estatura { get; set; }

        [Required(ErrorMessage = "Ingrese Peso")]
        public float Peso { get; set; }

        public float Imc { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha De Creacion Registro")]
        public DateTime FechaRegistro { get; set; }
    }
}