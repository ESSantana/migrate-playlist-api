using System.Collections.Generic;
using Newtonsoft.Json;

namespace PlaylistApi.Domain.Entities
{

    public class DeezerUser {
        [JsonProperty("data")]
        public List<User> Users { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("next")]
        public string Next { get; set; } 
    }

    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }    
        [JsonProperty("picture")]
        public string PictureUrl { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}