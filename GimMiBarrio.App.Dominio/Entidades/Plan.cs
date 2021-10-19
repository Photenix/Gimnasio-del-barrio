using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace GimMiBarrio.App.Dominio
{
    public class Plan
    {
        private List<string> diasSeleccionados;

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public decimal CostoMensual { get; set; }
        public string Descripcion { get; set; }
    }
}