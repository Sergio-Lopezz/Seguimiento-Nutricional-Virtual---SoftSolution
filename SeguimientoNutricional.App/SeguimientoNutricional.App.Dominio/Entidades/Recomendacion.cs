using System;
using System.ComponentModel.DataAnnotations;

namespace SeguimientoNutricional.App.Dominio
{
    public class Recomendacion
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe asignar una recomendacion"), StringLength(200)]
        public string Descripcion { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha De Creacion Recomendacion")]
        public DateTime FechaRegistro { get; set; }
    }
}