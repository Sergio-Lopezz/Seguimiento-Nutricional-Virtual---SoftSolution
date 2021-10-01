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
    public class PaginaEditarModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;

        public PaginaEditarModel(IRepositorioPaciente _repoPaciente)
        {
            this._repoPaciente = _repoPaciente;
        }

        [BindProperty]

        public Paciente Paciente { get; set; }

        
        public IActionResult OnGet(int pacienteId)
        {
            Paciente =_repoPaciente.GetPaciente(pacienteId);
            if (Paciente == null)
            { 
                return RedirectToPage("./NotFound");
            }
            else
            { 
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            else
            { 
                Paciente = _repoPaciente.UpdatePaciente(Paciente);
            }
            return RedirectToPage("./PaginaPaciente");
        }
    }
}
