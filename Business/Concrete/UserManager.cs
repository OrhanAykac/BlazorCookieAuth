using Business.Abstract;
using Entities.Dto;
using Entities.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;
public class UserManager : IUserService
{
    public BaseDataResponse<UserForLoginResponse> GetUserByEmail(string email)
    {
        //Burada veritabanı sorgusu yapılacak ve kullanıcı bilgileri varsa dönecek
        if (email == "orhanaykac@gmail.com")
        {
            return new BaseDataResponse<UserForLoginResponse>(
                Data: new UserForLoginResponse(
                    UserId: 1,
                    Email: "orhanaykac@gmail.com",
                    FirstName: "Orhan",
                    LastName: "Aykaç"));
        }
        else
        {
            return new BaseDataResponse<UserForLoginResponse>(
                Data: null,
                Success: false,
                Message: "UserNotFoundConstMessage");
        }
    }

    public BaseDataResponse<UserDto> GetUserById(int userId)
    {
        return new BaseDataResponse<UserDto>(
                       Data: new UserDto()
                       {
                           IsActive = true,
                           FirstName = "Orhan",
                           LastName = "Aykaç",
                           UserId = userId
                       });
    }
}
