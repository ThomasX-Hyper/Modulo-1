using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Damers.Models
{
    public class TipoProducto
    {

        [Key]
        [Required]
        [Display(Name ="TipoProducto")]
        public String id_tipo_producto { get; set; }


        [Required]
        [Display(Name ="Nombre")]
        public String nombre {  get; set; }

        [Required]
        [Display(Name ="Descripcion")]
        public String descripcion {  get; set; }
        [JsonIgnore]
        public ICollection<Producto> Producto{ get; set; }
    }
}
