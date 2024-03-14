using System.ComponentModel.DataAnnotations;

namespace Entities.Dto;
public class UserForLoginDto
{
    [Required,EmailAddress]
    public string Email { get; set; } =default!;

    [Required,DataType(DataType.Password)]
    public string Password { get; set; } = default!;
}
