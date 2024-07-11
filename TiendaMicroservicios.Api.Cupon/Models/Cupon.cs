using System.ComponentModel.DataAnnotations;

namespace TiendaMicroservicios.Api.Cupon.Models
{
    public class Cupon
    {
        public int CuponId { get; set; }
        public string CuponCode { get; set; }
        public double PorcetanjeDescuento { get; set; }
        public int DescuentoMinimo { get; set; }
    }
}
