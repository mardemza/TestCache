using System.Threading.Tasks;
using TestCache.Configuration.Dto;

namespace TestCache.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
