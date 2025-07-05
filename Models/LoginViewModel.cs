using System.ComponentModel.DataAnnotations;

namespace VPNAppFormS.Models
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "帳號或電子郵件")]
        public string LoginName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "密碼")]
        public string Password { get; set; }

        [Display(Name = "記住我")]
        public bool RememberMe { get; set; }
    }

}
