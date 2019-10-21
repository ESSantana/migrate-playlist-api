using System.Collections.Generic;
using PlaylistApi.Domain.Entities;

namespace PlaylistApi.Repository
{
    public interface IDeezerRepository
    {
        DeezerUser GetProfile(string name);
        DeezerPlaylist GetPLaylist(string playlist);
        List<DeezerMusics> GetMusics(string playlistId); 
        void CreatePlaylit(); 
    }
}