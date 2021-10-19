using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using GimMiBarrio.App.Dominio;
using GimMiBarrio.App.Persistencia;
using GimMiBarrio.App.Persistencia.AppRepositorios;

namespace GimMiBarrio.App.Presentacion.Pages.UsuarioRecurrentes
{
    public class EditModel : PageModel
    {
       private readonly IRepositorio _appContext;
        
        [BindProperty]
        
        
        public UsuarioRecurrente usuarioRecurrente  { get; set; } 

        public EditModel()
        {
            this._appContext  =new Repositorio(new GimMiBarrio.App.Persistencia.AppRepositorios.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? usuarioRecurrenteId)
        {
            
            if (usuarioRecurrenteId.HasValue)
            {
                usuarioRecurrente = _appContext.GetUsuarioRecurrente(usuarioRecurrenteId.Value);
            }
            else
            {
                usuarioRecurrente = new UsuarioRecurrente();
            }

            if (usuarioRecurrente == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();

        }

        //se ejecuta al presionar Editar en el formulario
        public IActionResult OnPost()
        {
            
            if(!ModelState.IsValid)
            {
                return Page();
            }
            if(usuarioRecurrente.Id > 0)
            {
               usuarioRecurrente = _appContext.UpdateUsuarioRecurrente( usuarioRecurrente);               
            }
            else
            {
               _appContext.AddUsuarioRecurrente( usuarioRecurrente );
            }
            return Page();
        }
    }
}