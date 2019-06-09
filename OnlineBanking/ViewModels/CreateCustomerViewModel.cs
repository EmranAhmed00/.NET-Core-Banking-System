using OnlineBanking.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBanking.ViewModels
{
    public class CreateCustomerViewModel
    {

        public int CustomerId { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Givenname { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string Streetaddress { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Zipcode { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string CountryCode { get; set; }
        [Required]
        public DateTime? Birthday { get; set; }
        [Required]
        public string NationalId { get; set; }
        [Required]
        public string Telephonecountrycode { get; set; }
        [Required]
        public string Telephonenumber { get; set; }
        [Required]
        public string Emailaddress { get; set; }

       
        public Transactions newTransactions { get; set; }


        public Dispositions Disposition { get; set; }

        public Accounts Account { get; set; }




    }


}

