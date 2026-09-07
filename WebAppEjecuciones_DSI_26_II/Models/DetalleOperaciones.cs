using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace WebAppEjecuciones_DSI_26_II.Models
{
    public class DetalleOperaciones
    {
        [Key]
        [Display(Name ="id")]
        [Required]
        public int IdDetalleOperacion { get; set; }
        [Display(Name ="Descripcion")]
        [Required(ErrorMessage ="Debe ingresar la descripcion del mensaje")]
        [MaxLength(100,ErrorMessage ="El campo no debe tener mas de 100 caracteres")]

        public string Descripcion { get; set; }
        [Display(Name ="Cantidad")]
        [Required]
        public int Cantidad { get; set; }
        [Display(Name ="precio")]
        [Required(ErrorMessage ="Debe ingresar el preciode la operacion")]

        public float Importe { get; set; }

        [Display(Name ="igv")]
        [Required]

        public float Igv { get; set; }
        [Display (Name ="total")]
        [Required]

        public float total { get; set; }

        public int IdCabeceraOperacion { get; set; }

        [JsonIgnore]
        [ForeignKey("IdCabeceraOperacion")]
        public virtual CabeceraOperacion CabeceraOperacion { get; private set; }
    }
}
