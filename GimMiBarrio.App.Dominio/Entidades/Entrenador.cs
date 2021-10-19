using System;

namespace GimMiBarrio.App.Dominio
{
    public class Entrenador
    {   //Propiedades, antes atributos de la clase o tabla
        public int Id {get;set;}       
        public string Identificacion {get;set;}
        public string Nombres {get;set;}
        public string Apellidos {get;set;}
    
        public DateTime FechaIngreso {get;set;}
        public decimal SalarioMensual {get;set;}
    }
}