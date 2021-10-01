using System.Collections.Generic;
using SeguimientoNutricional.App.Dominio;

namespace SeguimientoNutricional.App.Persistencia
{
    public interface IRepositorioPaciente
    {
        IEnumerable<Paciente> GetAllPacientes();

        Paciente AddPaciente(Paciente paciente);

        Paciente UpdatePaciente(Paciente paciente);
        
        void DeletePaciente(int idPaciente);

        Paciente GetPaciente(int idPaciente);   



    }
}