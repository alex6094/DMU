using System.ComponentModel.DataAnnotations;

namespace TemplateMVC.Models;

public class InputResponse
{
    [Required(ErrorMessage = "Please enter a name")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Please enter an age")]
    public int? Age { get; set; }
    [Required(ErrorMessage = "Please enter a phone number")]
    public int? PhoneNumber { get; set; }
    [Required(ErrorMessage = "Please enter an email address")]
    public string? Email { get; set; }
    
    
    
}