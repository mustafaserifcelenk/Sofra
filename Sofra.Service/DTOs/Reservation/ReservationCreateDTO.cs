using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sofra.Service.DTOs.Reservation
{
    public class ReservationCreateDTO
    {
        [DisplayName("Tarih")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }
        [DisplayName("Süre")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        public int Duration { get; set; }
        [DisplayName("Müşteri Sayısı")]
        [Required(ErrorMessage = "{0} alanı boş geçilmemelidir.")]
        [Range(1, 6, ErrorMessage = "{0} alanı 1 ile 6 arasında olmalıdır.")]
        public int CustomerCount { get; set; }
    }
}
