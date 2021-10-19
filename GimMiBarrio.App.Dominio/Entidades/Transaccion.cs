using System;

namespace GimMiBarrio.App.Dominio
{
    public class Transaccion
    {   //Propiedades, antes atributos de la clase o tabla
        public int Id {get;set;}       
        public string Codigo {get;set;}
        public string Estado {get;set;}
        public string Tipo {get;set;}

        public DateTime FechaLimite {get;set;}
        public DateTime FechaPago {get;set;}
        public string Descripcion {get;set;}
        
    }
}