using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IzmirGaz.Entities.Dtos
{
 public   class CampanyAddDto
    {
        [DisplayName("Firma Adı")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        [MaxLength(250,ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(3,ErrorMessage = "{0} {1}  Karakterden Az Olmamalıdır")]
        public string CompanyName { get; set; }

        [DisplayName("Adres")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir")]
        [MaxLength(300, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1}  Karakterden Az Olmamalıdır")]
        public string Address { get; set; }

        [DisplayName("Adres")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir")]
        [DisplayFormat(ApplyFormatInEditMode = true,DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime VisaDuration { get; set; }


        [DisplayName("Telefon")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir")]
        public string CompanyPhoneNumber { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir")]
        [MaxLength(150, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1}  Karakterden Az Olmamalıdır")]
        public string Email { get; set; }


        [DisplayName("Firma Sorumlusu Adı")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir")]
        [MaxLength(75, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1}  Karakterden Az Olmamalıdır")]
        public string CompanyManagerFirstName { get; set; }

        [DisplayName("Firma Sorumlusu Soyadı")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir")]
        [MaxLength(75, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(3, ErrorMessage = "{0} {1}  Karakterden Az Olmamalıdır")]
        public string CompanyManagerLastName { get; set; }

        [DisplayName("Firma Sorumlusu Telefonu")]
        public string CompanyManagerPhoneNumber { get; set; }

        [DisplayName("Firma Performans Puanı")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir")]
        public double CompanyPerformanceReport { get; set; }
        [DisplayName("İlk Seferde Gaz Açma Yüzdesi")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir")]
        public double PercentageOfGasFired { get; set; }

        [DisplayName("Aktif Mi?")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir")]
        public bool IsActive { get; set; }
    }
}
