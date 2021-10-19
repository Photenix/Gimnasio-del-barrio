using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using GimMiBarrio.App.Dominio;
using GimMiBarrio.App.Persistencia.AppRepositorios;

namespace GimMiBarrio.App.Presentacion.Pages.UsuarioRecurrentes
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorio _appContext;
        public UsuarioRecurrente usuarioRecurrente { get; set; }

        public DetailsModel()
        {
            this._appContext=new Repositorio(new GimMiBarrio.App.Persistencia.AppRepositorios.AppContext());
        }

        //se ejecuta al presionar Detalle en la lista
        public IActionResult OnGet(int usuarioRecurrenteId)
        {
            usuarioRecurrente = _appContext.GetUsuarioRecurrente(usuarioRecurrenteId);
            if(usuarioRecurrente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            return Page();
        }
    }
}