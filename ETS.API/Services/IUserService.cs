using ETS.API.DTOs;
using ETS.API.Models;
using System.Collections.Generic;

namespace ETS.API.Services
{
    public interface IUserService
    {
        bool Register(User user);

        List<UserDTO> GetUsers();

        //TODO: Silme ve tekil listeleme
    }
}
