using PlaylistApi.Domain.Entities;

namespace PlaylistApi.Repository.Interfaces
{
    public interface ISpotifyRepository
    {
        SpotifyPlaylist GetPLaylist(string playlist);
        void CreatePlaylit(); 
    }
}