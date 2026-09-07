using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Intrinsics.X86;
using System.Text.Json.Serialization;

namespace BackEndWebAppEjecuciones_DSI_26_II.Models
{
    public class DetalleOperacion
    {
        [Key]
        [Display(Name ="Id")]
        [Required]
        public int IdDetalleOperacion { get; set; }

        [Display(Name ="Descripcion")]
        [Required(ErrorMessage ="Debe de ingresar la descripcion de la operacion")]
        [MaxLength(100,ErrorMessage ="El campo no debe de tener mas de 100 caracteres")]
        public string Descripcion {  get; set; }

        [Display(Name ="Cantidad")]
        [Required(ErrorMessage ="Debe de ingresar la cantidad de la operacion")]
        public int Cantidad {  get; set; }

        [Display(Name ="Precio")]
        [Required(ErrorMessage ="Debe de ingresar el precio de la operacion")]
        public float Importe { get; set; }

        [Display(Name ="Igv")]
        [Required]
        public float Igv {  get; set; }
        [Display(Name ="Total")]
        [Required]
        public float Total {  get; set; }
        public int IdCabeceraOperacion { get; set; }
        [JsonIgnore]
        [ForeignKey("IdCabeceraOperacion")]
        public virtual CabeceraOperacion CabeceraOperacion { get;set; }
    }
}
