namespace Entities.Dto;
public record UserForLoginResponse(
    int UserId,
    string Email,
    string FirstName,
    string LastName);