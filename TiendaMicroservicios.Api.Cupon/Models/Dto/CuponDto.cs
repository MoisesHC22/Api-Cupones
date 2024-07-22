using System.ComponentModel.DataAnnotations;

namespace TiendaMicroservicios.Api.Cupon.Models.Dto
{
    public class CuponDto
    {
        [Key]
        public int CuponId { get; set; }
        [Required]
        public string CuponCode { get; set; }
        [Required]
        public double PorcetanjeDescuento { get; set; }
        [Required]
        public int DescuentoMinimo { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaExpiracion {  get; set; }
    }
}
