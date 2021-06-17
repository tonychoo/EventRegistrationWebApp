using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventRegistrationWebApp.Models
{
    public class Registration
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [MaxLength(30)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [MaxLength(50)]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Email entered is not valid")]
        [DataType(DataType.Text)]
        public string Email { get; set; }

        [MaxLength(1)]
        [DataType(DataType.Text)]
        public string Gender { get; set; }
        
        [DisplayName("Date Registered")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [Range(typeof(DateTime), "1/1/2019", "30/6/2019", ErrorMessage = "Allowed date is between {1:dd/MM/yyyy} to {2:dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; }

        [DisplayName("Selected Days")]
        public string EventDays { get; set; }

        [DisplayName("Additional Request")]
        [MaxLength(100)]
        public string AdditionalRequest { get; set; }
    }
}