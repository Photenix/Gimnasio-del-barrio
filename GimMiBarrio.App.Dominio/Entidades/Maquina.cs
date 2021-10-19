using System;

namespace GimMiBarrio.App.Dominio
{
    public class Maquina
    {   //Propiedades, antes atributos de la clase o tabla
        public int Id {get;set;}       
        public string Codigo {get;set;}
        public string EstadoActual {get;set;}
        public decimal CostoRevision {get;set;}
        public DateTime FechaRevision {get;set;}
        
    }
}