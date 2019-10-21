using AutoMapper;
using PlaylistApi.Domain.Entities;
using PlaylistApi.Models.ViewModel;

namespace PlaylistApi.AutoMapper.Mappers
{
    public class SpotifyPlaylistMapper
    {
        public static void Map(Profile profile)
        {
            profile.CreateMap<SpotifyPlaylist, SpotifyPlaylistViewModel>();
        }
    }
}