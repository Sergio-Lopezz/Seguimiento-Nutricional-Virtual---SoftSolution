using SeguimientoNutricional.App.Dominio;
using System.Collections.Generic;
using System.Linq;


namespace SeguimientoNutricional.App.Persistencia
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
        private readonly AppContext _appContext = new AppContext(); //Se debe inicializar el AppContext() para trabjar desde el frontend

        //######################################################
        //Se utiliza cuando se trabaja con la .Consola
        
        /*
        private readonly AppContext _appContext;

        public RepositorioPaciente(AppContext appContext)
        {
            _appContext = appContext;
        }
        */
        //######################################################

        

        public Paciente AddPaciente(Paciente paciente)
        {
            var pacienteAdicionado = _appContext.Paciente.Add(paciente);
            _appContext.SaveChanges();
            return pacienteAdicionado.Entity;
        }

        public void DeletePaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Paciente.FirstOrDefault(p => p.Id == idPaciente);
            if (pacienteEncontrado == null)
            {
                return;
            }
            _appContext.Paciente.Remove(pacienteEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Paciente> GetAllPacientes()
        {
            return _appContext.Paciente;
        }

        public Paciente GetPaciente(int idPaciente)
        {
            var pacienteEncontrado = _appContext.Paciente.FirstOrDefault(p => p.Id == idPaciente);
            return pacienteEncontrado;
        }

        public Paciente UpdatePaciente(Paciente paciente)
        {
            var pacienteEncontrado = _appContext.Paciente.FirstOrDefault(p => p.Id == paciente.Id);
            if (pacienteEncontrado!=null)
            {
                pacienteEncontrado.DocumentoIdentidad=paciente.DocumentoIdentidad;
                pacienteEncontrado.Nombre=paciente.Nombre;
                pacienteEncontrado.Apellido=paciente.Apellido;
                pacienteEncontrado.Telefono=paciente.Telefono;
                pacienteEncontrado.Genero=paciente.Genero;
                pacienteEncontrado.Correo=paciente.Correo;
                pacienteEncontrado.Ciudad=paciente.Ciudad;
                pacienteEncontrado.FechaNacimiento=paciente.FechaNacimiento;
                pacienteEncontrado.Latitud=paciente.Latitud;
                pacienteEncontrado.Longitud=paciente.Longitud;
                pacienteEncontrado.Direccion=paciente.Direccion;

                _appContext.SaveChanges();
            }
            return pacienteEncontrado;
        }
    }
}