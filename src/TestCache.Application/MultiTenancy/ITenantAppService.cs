using Abp.Application.Services;
using TestCache.MultiTenancy.Dto;

namespace TestCache.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

