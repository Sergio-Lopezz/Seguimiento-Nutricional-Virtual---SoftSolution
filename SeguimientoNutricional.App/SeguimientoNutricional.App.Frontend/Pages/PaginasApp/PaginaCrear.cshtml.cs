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
    public class PaginaCrearModel : PageModel
    {
        private readonly IRepositorioPaciente _repoPaciente;

        
        public Paciente Paciente { get; set; }

        public PaginaCrearModel(IRepositorioPaciente _repoPaciente)
        { 
            this._repoPaciente = _repoPaciente;
        }
        public void OnGet() //Envia Informacion al HMTL
        {
            Paciente=new Paciente();
        }

        public IActionResult OnPost(Paciente paciente)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            _repoPaciente.AddPaciente(paciente);
            return RedirectToPage("../Index");
        }


    }
}
