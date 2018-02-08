using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HealthCare.MultiTenancy.Dto;

namespace HealthCare.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
