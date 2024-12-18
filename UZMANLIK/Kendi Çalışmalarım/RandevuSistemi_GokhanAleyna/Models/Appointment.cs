using System;

namespace RandevuSistemi_GokhanAleyna.Models
{
    public class Appointment
    {
        public int Id { get; set; } // Randevu ID'si
        public DateTime Date { get; set; } // Randevu tarihi
        public string ?Time { get; set; } // Randevu saati

        public int UserId { get; set; } // Kullanıcının ID'si
        public User? User { get; set; } // Kullanıcı bilgisi (Nullable)
    }
}
