using System.Threading.Tasks;
using HealthCare.Configuration.Dto;

namespace HealthCare.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
