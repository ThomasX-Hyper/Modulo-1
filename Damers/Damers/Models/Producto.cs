using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Damers.Models
{
    public class Producto
    {

        [Key]
        [Required]
        [Display(Name ="Idproducto")]
        public String id_producto {  get; set; }
        [Required]
        [Display(Name = "nombre")]
        public String nombre { get; set; }
        [Required]
        [Display(Name = "modelo")]
        public String modelo {  get; set; }
        [Required]
        [Display(Name = "color")]
        public String color { get; set; }
        [Required]
        [Display(Name = "Capacidad")]
        public String capacidad {  get; set; }

        public String id_tipo_producto { get; set; }
        [ForeignKey("id_tipo_producto")]

        public virtual TipoProducto TipoProducto { get; set; }
    }
}
