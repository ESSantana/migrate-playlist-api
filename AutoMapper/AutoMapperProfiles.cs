using AutoMapper;
using PlaylistApi.AutoMapper.Mappers;

namespace PlaylistApi.AutoMapper
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            SpotifyPlaylistMapper.Map(this);
            DeezerPlaylistMapper.Map(this);
            DeezerUserMapper.Map(this);
        }
    }
}