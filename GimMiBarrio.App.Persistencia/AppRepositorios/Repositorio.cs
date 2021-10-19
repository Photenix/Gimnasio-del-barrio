using System.Collections.Generic;
using System.Linq;
using System;
using GimMiBarrio.App.Dominio;

namespace GimMiBarrio.App.Persistencia
{
       public class Repositorio : IRepositorio
    {
        private readonly AppContext _appContext;

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
            //Console.WriteLine("PROBANDO EN LA IMPLEMENTACIÒND EL REPOSITORIO");
            var UsuarioRecurrenteAdicionado = _appContext.UsuarioRecurrente.Add(usuarioRecurrente );  //INSERT en la BD
            _appContext.SaveChanges();                  
            return UsuarioRecurrenteAdicionado.Entity;
            } catch
            {
                throw;
            }
                
           }

     IEnumerable<UsuarioRecurrente> IRepositorio.GetAllUsuarioRecurrentes()
     /*string? nombre)*/
        {
            return _appContext.UsuarioRecurrente;
           /*  if (nombre!= null){
                usuarioRecurrentes= _appContext.UsuarioRecurrentes.Where(p => p.nombre.Contains(nombre));
            } else
               usuarioRecurrentes= _appContext.UsuarioRecurrentes;
            
            return usuarioRecurrentes; */
        }
        UsuarioRecurrente IRepositorio.GetUsuarioRecurrente(int idUsuarioRecurrente)
       {
            return _appContext.UsuarioRecurrente.FirstOrDefault(p => p.Id == idUsuarioRecurrente);
       }
        UsuarioRecurrente IRepositorio.UpdateUsuarioRecurrente(UsuarioRecurrente UsuarioRecurrente)
        {
            var UsuarioRecurrenteEncontrado = _appContext.UsuarioRecurrente.FirstOrDefault(p => p.Id == UsuarioRecurrente.Id);
            if (UsuarioRecurrenteEncontrado != null)
            {
                UsuarioRecurrenteEncontrado.Identificacion  = UsuarioRecurrente.Identificacion;
                UsuarioRecurrenteEncontrado.Nombres          = UsuarioRecurrente.Nombres;
                _appContext.SaveChanges();
            }
            return UsuarioRecurrenteEncontrado;
        }
        
        void IRepositorio.DeleteUsuarioRecurrente(int idUsuarioRecurrente)
        {
            var UsuarioRecurrenteEncontrado = _appContext.UsuarioRecurrente.FirstOrDefault(p => p.Id == idUsuarioRecurrente);
            if (UsuarioRecurrenteEncontrado == null)
                return;
            _appContext.UsuarioRecurrente.Remove(UsuarioRecurrenteEncontrado);
            _appContext.SaveChanges();
        }

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