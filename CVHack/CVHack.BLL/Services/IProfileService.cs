using CVHack.Common;

namespace CVHack.BLL;

public interface IProfileService
{
    Task<Result<ProfileResponseDto>> GetProfileAsync(string userId);
    Task<Result<ProfileResponseDto>> UpdateProfileAsync(string userId, UpdateProfileDto dto);
}
