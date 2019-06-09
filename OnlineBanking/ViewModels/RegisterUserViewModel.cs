using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBanking.ViewModels
{
    public class RegisterUserViewModel
    {
        [Required]
        [DisplayName("Insert User Name")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Insert Password")]
        public string Password { get; set; }

        public string RoleName { get; set; }
    }
}
