using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SeguimientoNutricional.App.Persistencia;
using SeguimientoNutricional.App.Dominio;

namespace SeguimientoNutricional.App.Frontend.Pages.PaginasApp
{
    public class PaginaPacienteModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;

        public IEnumerable<Paciente> Pacientes { get; set; }

        public PaginaPacienteModel(IRepositorioPaciente _repoPaciente)
        { 
            this._repoPaciente = _repoPaciente;
        }
        public void OnGet() //Envia Informacion al HMTL
        {
            Pacientes=_repoPaciente.GetAllPacientes();
        }
    }
}
