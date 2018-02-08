using System.Threading.Tasks;
using Abp.Configuration;
using Abp.Zero.Configuration;
using HealthCare.Authorization.Accounts.Dto;
using HealthCare.Authorization.Users;

namespace HealthCare.Authorization.Accounts {
    public class AccountAppService : HealthCareAppServiceBase, IAccountAppService {
        private readonly UserRegistrationManager _userRegistrationManager;

        /// <summary>
        ///     ctor().
        /// </summary>
        /// <param name="userRegistrationManager"></param>
        public AccountAppService(UserRegistrationManager userRegistrationManager) {
            _userRegistrationManager = userRegistrationManager;
        }

        public async Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input) {
            var tenant = await TenantManager.FindByTenancyNameAsync(input.TenancyName);
            if (tenant == null) {
                return new IsTenantAvailableOutput(TenantAvailabilityState.NotFound);
            }

            if (!tenant.IsActive) {
                return new IsTenantAvailableOutput(TenantAvailabilityState.InActive);
            }

            return new IsTenantAvailableOutput(TenantAvailabilityState.Available, tenant.Id);
        }

        public async Task<RegisterOutput> Register(RegisterInput input) {
            var user = await _userRegistrationManager.RegisterAsync(
                input.Name,
                input.Surname,
                input.EmailAddress,
                input.UserName,
                input.Password,
                true // Assumed email address is always confirmed. Change this if you want to implement email confirmation.
            );

            var isEmailConfirmationRequiredForLogin = await SettingManager.GetSettingValueAsync<bool>(AbpZeroSettingNames.UserManagement.IsEmailConfirmationRequiredForLogin);

            return new RegisterOutput {
                CanLogin = user.IsActive && (user.IsEmailConfirmed || !isEmailConfirmationRequiredForLogin)
            };
        }
    }
}
