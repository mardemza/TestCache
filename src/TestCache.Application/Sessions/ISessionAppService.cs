using System.Threading.Tasks;
using Abp.Application.Services;
using TestCache.Sessions.Dto;

namespace TestCache.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
