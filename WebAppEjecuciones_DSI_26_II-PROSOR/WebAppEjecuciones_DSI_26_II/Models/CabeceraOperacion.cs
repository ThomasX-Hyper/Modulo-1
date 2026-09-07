using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BackEndWebAppEjecuciones_DSI_26_II.Models
{
    public class CabeceraOperacion
    {
        [Key]
        [Display(Name ="Id")]
        [Required]
        public int IdCabeceraOperacion {  get; set; }

        [Display(Name ="Cliente")]
        [Required]
        [MaxLength(100)]
        public string Cliente {  get; set; }
        
        [Display(Name ="Registro")]
        [Required]
        public DateTime Registro {  get; set; }
        
        [JsonIgnore]
        public ICollection<DetalleOperacion> DetalleOperacion { get; set; }
    }
}
