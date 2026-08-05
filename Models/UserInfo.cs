using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Ad bölməsi doldurulmalıdır.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Telefon bölməsi doldurulmalıdır.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Email bölməsi doldurulmalıdır.")]
        [EmailAddress(ErrorMessage ="Xətalı email")]
        public string? Email { get; set; }

        [Required(ErrorMessage = "İştirak statusunuzu qeyd edin.")]
        public bool? WillAttend { get; set; }
    }
}