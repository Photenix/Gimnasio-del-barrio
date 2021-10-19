using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;

using GimMiBarrio.App.Dominio;
using GimMiBarrio.App.Persistencia;
using GimMiBarrio.App.Persistencia.AppRepositorios;

namespace GimMiBarrio.App.Presentacion.Pages.UsuarioRecurrentes
{
    //[Authorize]
    public class ListModel : PageModel
    {
        private readonly IRepositorio _appContext;
        public IEnumerable<UsuarioRecurrente> usuarioRecurrentes {get; set;} 

        public string searchString;     

        public ListModel()
        {
            this._appContext = new Repositorio (new GimMiBarrio.App.Persistencia.AppRepositorios.AppContext());
            //GimMiBarrio.App.Persistencia.AppRepositorios.AppContext());
        }
       
        public void OnGet()
        {
            usuarioRecurrentes =_appContext.GetAllUsuarioRecurrentes(searchString); 
        }

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            usuarioRecurrentes = _appContext.GetAllUsuarioRecurrentes(searchString);
            return Page();
        }
    }
}