using System.Collections.Generic;
using System.Linq;
using System;
using Microsoft.EntityFrameworkCore;

using GimMiBarrio.App.Dominio;

namespace GimMiBarrio.App.Persistencia.AppRepositorios
{
    public class Repositorio : IRepositorio
    {
        private readonly AppContext _appContext;
        public IEnumerable<UsuarioRecurrente> usuarioRecurrentes { get; set; }
        public IEnumerable<Admin> admins { get; set; }
        //public IEnumerable<Entrenador> entrenadores {get; set;} 
        public IEnumerable<Gimnasio> gimnasios { get; set; }
        public IEnumerable<Login> logins { get; set; }
        public IEnumerable<Maquina> maquinas { get; set; }
        public IEnumerable<Plan> planes { get; set; }
        public IEnumerable<PlanDia> planDias { get; set; }
        //public IEnumerable<Transaccion> transacciones{get; set;} 

        public Repositorio(AppContext appContext)
        {
            _appContext = appContext;
        }

        //AQUÍ CADA UNO DE LOS MÉTODOS DEL CRUD, REFERENCIADOS EN LA INTERFACE
        //USUARIO_RECURRENTE

        UsuarioRecurrente IRepositorio.AddUsuarioRecurrente(UsuarioRecurrente usuarioRecurrente)
        {
            try
            {
                var UsuarioRecurrenteAdicionado = _appContext.UsuarioRecurrentes.Add(usuarioRecurrente);  //INSERT en la BD
                _appContext.SaveChanges();
                return UsuarioRecurrenteAdicionado.Entity;
            }
            catch
            {
                throw;
            }

        }

        IEnumerable<UsuarioRecurrente> IRepositorio.GetAllUsuarioRecurrentes(string? nombre)
        {
            // return _appContext.UsuarioRecurrentes;
            if (nombre != null)
            {
                usuarioRecurrentes = _appContext.UsuarioRecurrentes.Where(p => p.Nombres.Contains(nombre)); //like sobre la tabla
            }
            else
                usuarioRecurrentes = _appContext.UsuarioRecurrentes; //select * from usuario

            return usuarioRecurrentes;
        }
        UsuarioRecurrente IRepositorio.GetUsuarioRecurrente(int? idUsuarioRecurrente)
        {
            return _appContext.UsuarioRecurrentes.FirstOrDefault(p => p.Id == idUsuarioRecurrente);
        }
        UsuarioRecurrente IRepositorio.UpdateUsuarioRecurrente(UsuarioRecurrente usuarioRecurrente)
        {
            var UsuarioRecurrenteEncontrado = _appContext.UsuarioRecurrentes.FirstOrDefault(p => p.Id == usuarioRecurrente.Id);
            if (UsuarioRecurrenteEncontrado != null)
            {
                UsuarioRecurrenteEncontrado.Identificacion = usuarioRecurrente.Identificacion;
                UsuarioRecurrenteEncontrado.Nombres = usuarioRecurrente.Nombres;
                _appContext.SaveChanges();
            }
            return UsuarioRecurrenteEncontrado;
        }

        void IRepositorio.DeleteUsuarioRecurrente(int idUsuarioRecurrente)
        {
            var UsuarioRecurrenteEncontrado = _appContext.UsuarioRecurrentes.FirstOrDefault(p => p.Id == idUsuarioRecurrente);
            if (UsuarioRecurrenteEncontrado == null)
                return;
            _appContext.UsuarioRecurrentes.Remove(UsuarioRecurrenteEncontrado);
            _appContext.SaveChanges();
        }

        // Implementación Planes
        Plan IRepositorio.AddPlan(Plan plan)
        {
            try
            {
                var PlanAdicionado = _appContext.Planes.Add(plan);  //INSERT en la BD
                _appContext.SaveChanges();
                return PlanAdicionado.Entity;
            }
            catch
            {
                throw;
            }

        }

        IEnumerable<Plan> IRepositorio.GetAllPlanes(string? nombre)
        {
            // return _appContext.Planes;
            if (nombre != null)
            {
                planes = _appContext.Planes.Where(p => p.Nombre.Contains(nombre)); //like sobre la tabla
            }
            else
                planes = _appContext.Planes; //select * from usuario

            return planes;
        }
        Plan IRepositorio.GetPlan(int? idPlan)
        {
            return _appContext.Planes.FirstOrDefault(p => p.Id == idPlan);
        }
        Plan IRepositorio.UpdatePlan(Plan plan)
        {
            var PlanEncontrado = _appContext.Planes.FirstOrDefault(p => p.Id == plan.Id);
            if (PlanEncontrado != null)
            {
                PlanEncontrado.Codigo = plan.Codigo;
                PlanEncontrado.Nombre = plan.Nombre;
                _appContext.SaveChanges();
            }
            return PlanEncontrado;
        }

        void IRepositorio.DeletePlan(int idPlan)
        {
            var PlanEncontrado = _appContext.Planes.FirstOrDefault(p => p.Id == idPlan);
            if (PlanEncontrado == null)
                return;
            _appContext.Planes.Remove(PlanEncontrado);
            _appContext.SaveChanges();
        }

        //Fin implementación
        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}