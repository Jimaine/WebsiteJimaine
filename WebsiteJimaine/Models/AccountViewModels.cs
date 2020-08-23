using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebsiteJimaine.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class ExternalLoginConfirmationViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ExternalLoginListViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string ReturnUrl { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class SendCodeViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public string SelectedProvider { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ReturnUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public bool RememberMe { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class VerifyCodeViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        public string Provider { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ReturnUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Diesen Browser merken?")]
        public bool RememberBrowser { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool RememberMe { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ForgotViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class LoginViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [Display(Name = "E-Mail")]
        [EmailAddress]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Kennwort")]
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Speichern?")]
        public bool RememberMe { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class RegisterViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "\"{0}\" muss mindestens {2} Zeichen lang sein.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Kennwort")]
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Kennwort bestätigen")]
        [Compare("Password", ErrorMessage = "Das Kennwort entspricht nicht dem Bestätigungskennwort.")]
        public string ConfirmPassword { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ResetPasswordViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "\"{0}\" muss mindestens {2} Zeichen lang sein.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Kennwort")]
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataType(DataType.Password)]
        [Display(Name = "Kennwort bestätigen")]
        [Compare("Password", ErrorMessage = "Das Kennwort stimmt nicht mit dem Bestätigungskennwort überein.")]
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Code { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public class ForgotPasswordViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        [Required]
        [EmailAddress]
        [Display(Name = "E-Mail")]
        public string Email { get; set; }
    }
}
