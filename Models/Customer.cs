using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MIS4200_1045.Models
{
    public class Customer
    {
        public int customerID { get; set; }

        [Display(Name ="First Name")]
        [Required]
        public string firstName { get; set; }

        [Display(Name ="Customer Last Name")]
        [Required]
        [StringLength(30, ErrorMessage ="Customer last names must be 30 characters or less")]
        [RegularExpression("^([a-zA-Z']+)$", ErrorMessage ="Customer last name may only included letters and an option '")]
        public string lastName { get; set; }
        
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage ="A customer email address is required")]
        public string email { get; set; }
        public string phone { get; set; }
        
        [DisplayFormat(DataFormatString ="{0:d}", ApplyFormatInEditMode =true)]
        public DateTime customerSince { get; set; }

        [Display(Name ="Customer Name")]
        public string fullName
        {
            get
            {
                return lastName + ", " + firstName;
            }
        }
        public ICollection<Orders> orders { get; set; }


    }
}