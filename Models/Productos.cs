using System;
using System.ComponentModel.DataAnnotations;

namespace Jordy_P1_APL2.Models
{
    public class Productos
    {
        [Key]
        [Required(ErrorMessage = "No debe de estar Vacio el campo'ProductoId'")]
        [Range(0, 100, ErrorMessage = "El Campo 'ProductoId' no puede ser 0 o (mayor a 1000),")]
        public int ProductoId { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacio el campo'Descripcion'")]
        [MinLength(4, ErrorMessage = "El Campo 'Descripcion' Debe tener por lo menos (4 caracteres),")]
        [RegularExpression(@"\S(,*)\S", ErrorMessage = "Debe ser un texto,")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacio el campo'Existencia'")]
        public decimal Existencia { get; set; }
        [Required(ErrorMessage = "No debe de estar Vacio el campo'Costo'")]
        public decimal Costo { get; set; }

        [Required(ErrorMessage = "No debe de estar Vacio el campo'ValorInventario'")]
        public decimal ValorInventario { get; set; }
    }
}
