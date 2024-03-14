using Entities.Dto;
using Entities.Response;

namespace Business.Abstract;
public interface IUserService
{
    BaseDataResponse<UserForLoginResponse> GetUserByEmail(string email);
    BaseDataResponse<UserDto> GetUserById(int userId);
}
