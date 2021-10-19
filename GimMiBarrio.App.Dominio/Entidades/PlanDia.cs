using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GimMiBarrio.App.Dominio
{
    public class PlanDia
    {
        public int Id { get; set; }        
        public string DiasSeleccionados { get; set; }
        public DateTime Horario { get; set; }
        public Plan Plan { get; set; }
    }
}