//Directivas
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using GimMiBarrio.App.Dominio;

namespace GimMiBarrio.App.Persistencia.AppRepositorios
{
    public interface IRepositorio
    {
        //contratos o firmas de los metodos UsuarioRecurrente        
        UsuarioRecurrente AddUsuarioRecurrente(UsuarioRecurrente usuarioRecurrente);
        IEnumerable<UsuarioRecurrente> GetAllUsuarioRecurrentes(string? nombre);   /*string nombre);*/
        UsuarioRecurrente GetUsuarioRecurrente(int? idUsuarioRecurrente);
        UsuarioRecurrente UpdateUsuarioRecurrente(UsuarioRecurrente usuarioRecurrente);
        void DeleteUsuarioRecurrente(int idUsuarioRecurrente);

        //contratos o firmas para los metodos Planes
        Plan AddPlan(Plan plan);
        IEnumerable<Plan> GetAllPlanes(string? nombre);   /*string nombre);*/
        Plan GetPlan(int? idPlan);
        Plan UpdatePlan(Plan plan);
        void DeletePlan(int idPlan);
        //contratos o firmas para los metodos demás entidades -PENDIENTE
    }
}