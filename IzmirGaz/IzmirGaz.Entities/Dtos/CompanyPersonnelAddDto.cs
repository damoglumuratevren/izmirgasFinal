using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;
using IzmirGaz.Entities.Concrete;

namespace IzmirGaz.Entities.Dtos
{
    public class CompanyPersonnelAddDto
    {
        [DisplayName("Personel Adı")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        [MaxLength(75, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(5, ErrorMessage = "{0} {1}  Karakterden Az Olmamalıdır")]
        public string FirstName { get; set; }

        [DisplayName("Personel Soyadı")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        [MaxLength(75, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(5, ErrorMessage = "{0} {1}  Karakterden Az Olmamalıdır")]
        public string LastName { get; set; }


        [DisplayName("Personel Telefonu")]
        public string PhoneNumber { get; set; }

        [DisplayName("Personel Türü")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        [MaxLength(50, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(5, ErrorMessage = "{0} {1}  Karakterden Az Olmamalıdır")]
        public string PersonelType { get; set; }


        [DisplayName("Personel Fotografı")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        [MaxLength(250, ErrorMessage = "{0} {1} Karakterden Büyük Olmamalıdır")]
        [MinLength(5, ErrorMessage = "{0} {1}  Karakterden Az Olmamalıdır")]
        public string PersonelImg { get; set; }

        [DisplayName("Şirket Bilgisi")]
        [Required(ErrorMessage = "{0} Boş Geçilmemelidir.")]
        public int CompanyId { get; set; }

        public Company Company { get; set; }
    }
}
