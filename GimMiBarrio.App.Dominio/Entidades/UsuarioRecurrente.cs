using System;

namespace GimMiBarrio.App.Dominio
{
    public class UsuarioRecurrente
    {   //Propiedades, antes atributos de la clase o tabla
        public int Id {get;set;}       
        public string Identificacion {get;set;}
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
        public string Estado {get;set;}
        public DateTime FechaIngreso {get;set;}
        public string PesoInicial {get;set;}
        public string PesoActual {get;set;}
        
       // [ForeignKey("Plan")]
        public Plan Plan {get;set;}
    }
}