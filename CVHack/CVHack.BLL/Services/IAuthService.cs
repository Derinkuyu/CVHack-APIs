using CVHack.BLL.DTOs;
using CVHack.Common;
using System.Threading.Tasks;

namespace CVHack.BLL.Services;

public interface IAuthService
{
    Task<Result<AuthResultDto>> RegisterJobSeekerAsync(RegisterJobSeekerDto dto);
    Task<Result<AuthResultDto>> LoginAsync(LoginDto dto);
}
