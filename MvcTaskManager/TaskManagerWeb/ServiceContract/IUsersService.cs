using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagerWeb.Identity;
using TaskManagerWeb.ViewModels;

namespace TaskManagerWeb.ServiceContract
{
    public interface IUsersService
    {
        Task<ApplicationUser> Authenticate(LoginViewModel loginViewModel);
    }
}
