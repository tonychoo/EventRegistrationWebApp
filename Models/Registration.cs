using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventRegistrationWebApp.Models
{
    public class Registration
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [DataType(DataType.Text)]
        public string Name { get; set; }
        [DataType(DataType.Text)]
        public string Email { get; set; }

        [DataType(DataType.Text)]
        public string Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        [NotMapped]
        public string[] EventDays { get; set; }

        public string AdditionalRequest { get; set; }
    }
}