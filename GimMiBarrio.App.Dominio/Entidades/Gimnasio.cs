using System;

namespace GimMiBarrio.App.Dominio
{
    public class Gimnasio
    {   //Propiedades, antes atributos de la clase o tabla
        public int Id {get;set;}       
        public string Codigo {get;set;}
        public string Nombre {get;set;}
        public string Direccion {get;set;}
        public string Telefono {get;set;}
        public decimal ArriendoMensual {get;set;}
        
    }
}