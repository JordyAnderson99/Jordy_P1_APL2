using System;
using System.ComponentModel.DataAnnotations;

namespace Jordy_P1_APL2.Models
{
    public class Productos
    {
        [Key]
        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public decimal Existencia { get; set; }
        public decimal costo { get; set; }
        public decimal ValorInventario { get; set; }
    }
}
