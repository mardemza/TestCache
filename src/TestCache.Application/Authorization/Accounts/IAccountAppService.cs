using System.Threading.Tasks;
using Abp.Application.Services;
using TestCache.Authorization.Accounts.Dto;

namespace TestCache.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
