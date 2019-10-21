using AutoMapper;
using PlaylistApi.Domain.Entities;
using PlaylistApi.Models.ViewModel;

namespace PlaylistApi.AutoMapper.Mappers
{
    public static class DeezerPlaylistMapper
    {
        public static void Map(Profile profile)
        {
            profile.CreateMap<DeezerPlaylist, DeezerPlaylistViewModel>();
        }
    }
}