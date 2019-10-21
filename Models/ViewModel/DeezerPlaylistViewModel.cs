using System.Collections.Generic;
using PlaylistApi.Domain.Entities;

namespace PlaylistApi.Models.ViewModel
{
    public class DeezerPlaylistViewModel
    {
        public List<Playlist> Playlist { get; set; }
        public int Total { get; set; }
        public string Next { get; set; }
    }
}