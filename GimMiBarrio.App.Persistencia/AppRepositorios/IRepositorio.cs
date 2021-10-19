//Directivas
using System;
using System.Collections.Generic;
using System.Linq;

using GimMiBarrio.App.Dominio;

namespace GimMiBarrio.App.Persistencia
{
    public interface IRepositorio
    {
        //contratos o firmas de los metodos UsuarioRecurrente        
        UsuarioRecurrente AddUsuarioRecurrente(UsuarioRecurrente usuarioRecurrente);
        IEnumerable<UsuarioRecurrente> GetAllUsuarioRecurrentes();   /*string nombre);*/
        UsuarioRecurrente GetUsuarioRecurrente(int idUsuarioRecurrente);
        UsuarioRecurrente UpdateUsuarioRecurrente(UsuarioRecurrente usuarioRecurrente);
        void DeleteUsuarioRecurrente(int idUsuarioRecurrente);

        //contratos o firmas para los metodos demás entidades -PENDIENTE  
    }
}