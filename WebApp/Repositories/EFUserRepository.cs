using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using NuGet.Common;
using System;
using WebApp.Models;
using WebApp.Services;

namespace WebApp.Repositories
{
    public class EFUserRepository : IUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailService _emailService;
        private readonly IConfiguration _configuration;
        public EFUserRepository(UserManager<ApplicationUser> userManager, IEmailService emailService, IConfiguration configuration)
        {
            _userManager = userManager;
            _emailService = emailService;
            _configuration = configuration;
        }
        public async Task<ApplicationUser> GetUserByEmailAsync(string email)
        {
            return await _userManager.FindByEmailAsync(email);
        }
        public async Task GenerateForgotPasswordTokenAsync(ApplicationUser user)
        {
            var token = await _userManager.GeneratePasswordResetTokenAsync(user);
            if(!string.IsNullOrEmpty(token))
            {
                await SendForgotPasswordEmail(user, token);
            }
        }
        private async Task SendForgotPasswordEmail(ApplicationUser user, string token)
        {
            string appDomain = _configuration.GetValue<string>("Application:AppDomain");
            string confirmationLink = _configuration.GetValue<string>("Application:ForgotPassword");
            UserEmailOptions options = new UserEmailOptions
            {
                ToEmails = new List<string>() { user.Email },
                PlaceHolders = new List<KeyValuePair<string, string>>()
                {
                    new KeyValuePair<string, string>("{{UserName}}", user.UserName),
                    new KeyValuePair<string, string>("{{Link}}",
                    string.Format(appDomain + confirmationLink, user.Id, token))
                }
            };
            await _emailService.SendEmailForForgotPassword(options);
        }

        //Xử lý lấy lại password
        public async Task<IdentityResult> ResetPasswordAsync(ResetPassword model)
        {
            return await _userManager.ResetPasswordAsync(await _userManager.FindByIdAsync(model.UserId), model.Token, model.NewPassword);
        }

        public async Task<IEnumerable<UserInfo>> GetAllAsync()
        {
            var users = await _userManager.Users.ToListAsync();
            var userWithRolesList = new List<UserInfo>();

            foreach (var user in users)
            {
                var roles = await _userManager.GetRolesAsync(user);
                var userWithRoles = new UserInfo
                {
                    Id = user.Id,
                    Username = user.UserName,
                    TenKhachHang = user.TenKhachHang,
                    DiaChi = user.DiaChi,
                    Email = user.Email,
                    Phone = user.PhoneNumber,
                    Avatar = user.Avatar,
                    Role = roles[0],
                };
                userWithRolesList.Add(userWithRoles);
            }

            return userWithRolesList;
        }
    }
}
