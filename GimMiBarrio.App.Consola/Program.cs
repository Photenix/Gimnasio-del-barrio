using System;
using GimMiBarrio.App.Dominio;
using GimMiBarrio.App.Persistencia;

namespace GimMiBarrio.App.Consola
{
    class Program
    {
        private static IRepositorio _repoUsuarioRecurrente = new Repositorio (new Persistencia.AppContext());
        static void Main(string[] args)
        {
            //Console.WriteLine("PROBANDO INSERTAR DBCONTEXT-BD");
            Console.WriteLine("En el metodo");

           // AddUsuarioRecurrente();
            GetUsuarioRecurrente(1);
            /* GetAllUsuarioRecurrentes();
            
            UpdateUsuarioRecurrente();
            DeleteUsuarioRecurrente(); */
        }
        
        private static void AddUsuarioRecurrente()
        {
            //CREAR manualmente 
            Console.WriteLine("PRUEBA EN EL METODO");
            var usuarioRecurrente = new UsuarioRecurrente
            {
                Identificacion = "102030",
                Nombres = "Nombre Prueba",
                Apellidos ="Ibanez",
                Estado = "Activo",
                FechaIngreso = DateTime.Now,
                PesoInicial = "70 Kg",
                PesoActual = "55 Kg" 
      
            };
            _repoUsuarioRecurrente.AddUsuarioRecurrente(usuarioRecurrente);
        }
        
        private static void GetUsuarioRecurrente(int idUsuarioRecurrente)
        {
            var usuarioRecurrente= _repoUsuarioRecurrente.GetUsuarioRecurrente(idUsuarioRecurrente);
            Console.WriteLine(usuarioRecurrente.Nombres+" "+usuarioRecurrente.Apellidos);
        }

    }
}
