using System;
using SeguimientoNutricional.App.Dominio;
using SeguimientoNutricional.App.Persistencia;

namespace SeguimientoNutricional.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente= new RepositorioPaciente(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente();
            //RemovePaciente(1);
            GetAllPacientes();
            BuscarPaciente(2);
        }

        //Paciente#################################

        private static void AddPaciente()
        {
            var paciente = new Paciente{
                DocumentoIdentidad="10233044",
                Nombre="Samuel", 
                Apellido="Cruz", 
                Telefono="3208976534",
                Genero=Genero.Masculino,
                Correo="samuelCruz@gmail.com",
                Ciudad="Manizales", 
                FechaNacimiento= new DateTime(1970,06,29),
                Latitud=34.567F,
                Longitud=36.000F,
                Direccion="Calle68#35a-150"            

            };
            _repoPaciente.AddPaciente(paciente);
        }

        private static void RemovePaciente(int idPaciente)
        {
            _repoPaciente.DeletePaciente(idPaciente);
        }

        private static void GetAllPacientes()
        {
            var listaPacientes=_repoPaciente.GetAllPacientes();
            foreach(Paciente pa in listaPacientes)
            {
                Console.WriteLine("Paciente-> Id="+ pa.Id + " - " +pa.Nombre);
            }
        }

        private static void BuscarPaciente(int idPaciente)
        {
            var paciente=_repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine("Paciente->" + paciente.Nombre + " " +paciente.Apellido);
        }

        
    }
}
