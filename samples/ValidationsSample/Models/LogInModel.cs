using System.ComponentModel.DataAnnotations;

namespace ValidationsSample.Models;

public class LogInModel
{
    [Required, EmailAddress]
    public string Email { get; set; }

    [Required, MinLength(8), MaxLength(16)]
    public string Password { get; set; }

    [Required, MinLength(8), MaxLength(16)]
    public string ConfirmPassword { get; set; }
}