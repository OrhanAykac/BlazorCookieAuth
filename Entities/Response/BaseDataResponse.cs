namespace Entities.Response;

public record BaseDataResponse<T>(
    T? Data,
    bool Success = true,
    string Message = "");
