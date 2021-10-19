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

namespace GimMiBarrio.App.Presentacion.Pages.Planes
{
    //[Authorize]
    public class ListModel : PageModel
    {
        private readonly IRepositorio _appContext;
        public IEnumerable<Plan> planes {get; set;} 

        public string searchString;     

        public ListModel()
        {
            this._appContext = new Repositorio (new GimMiBarrio.App.Persistencia.AppRepositorios.AppContext());
            //GimMiBarrio.App.Persistencia.AppRepositorios.AppContext());
        }
       
        public void OnGet()
        {
            planes =_appContext.GetAllPlanes(searchString); 
        }

        public IActionResult OnPost(string? searchString)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            planes = _appContext.GetAllPlanes(searchString);
            return Page();
        }
    }
}