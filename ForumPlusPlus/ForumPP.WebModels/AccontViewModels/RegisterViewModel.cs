using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ForumPP.WebModels.AccontViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Please enter username!")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Please enter email!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter password!")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Please confirm your password!")]
        public string ConfirmPassword { get; set; }
    }
}
