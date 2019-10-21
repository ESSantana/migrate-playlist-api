using System.Collections.Generic;
using Newtonsoft.Json;

namespace PlaylistApi.Domain.Entities
{
    public class DeezerPlaylist {
        [JsonProperty("data")]
        public List<Playlist> Playlist { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("next")]
        public string Next { get; set; }
    }

    public class Playlist
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("nb_tracks")]
        public int Tracks { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("picture")]
        public string PictureUrl { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}