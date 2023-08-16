using HRMS.ViewModel.Models;
using HRMS.ViewModel.ResponseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMS.Services.AuthService.Interface
{
    public interface IAuthService
    {
        Task<AuthServiceResponse> SeedRolesAsync();
        Task<AuthServiceResponse> RegisterAsync(RegisterModel registerModel);
        Task<AuthServiceResponse> LoginAsync(LoginModel loginModel);
    }
}
