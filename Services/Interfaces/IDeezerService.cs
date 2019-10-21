using System.Collections.Generic;
using PlaylistApi.Domain.Entities;

namespace PlaylistApi.Services
{
    public interface IDeezerService
    {
        DeezerUser GetProfile(string name);
        DeezerPlaylist GetPlaylist(string playlistName);    
        List<DeezerMusics> GetMusics(string playlistId);
        void CreatePlaylist();
    }
}