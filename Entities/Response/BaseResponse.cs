namespace Entities.Response;
public record BaseResponse(
    bool Success=true,
    string Message = "DefaultSuccesMessage");
