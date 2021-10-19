using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using GimMiBarrio.App.Dominio;
using GimMiBarrio.App.Persistencia;
using GimMiBarrio.App.Persistencia.AppRepositorios;

namespace GimMiBarrio.App.Presentacion.Pages.Planes
{
    public class EditModel : PageModel
    {
       private readonly IRepositorio _appContext;

        [BindProperty]
        public Plan plan  { get; set; } 

        public EditModel()
        {
            this._appContext  =new Repositorio(new GimMiBarrio.App.Persistencia.AppRepositorios.AppContext());
        }
     

        //se ejecuta al presionar Editar en la lista
        public IActionResult OnGet(int? planId)
        {
            if (planId.HasValue)
            {
                plan = _appContext.GetPlan(planId.Value);
            }
            else
            {
                plan = new Plan();
            }

            if (plan == null)
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
            if(plan.Id > 0)
            {
               plan = _appContext.UpdatePlan( plan);               
            }
            else
            {
               _appContext.AddPlan( plan );
            }
            return Page();
        }
    }
}