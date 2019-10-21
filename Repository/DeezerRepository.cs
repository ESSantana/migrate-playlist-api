using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using PlaylistApi.Domain.Entities;
using RestSharp;

namespace PlaylistApi.Repository
{
    public class DeezerRepository : IDeezerRepository
    {
        private readonly string URL_DEEZER = Environment.GetEnvironmentVariable("URL_DEEZER");
        private RestClient client;

        public DeezerRepository ()
        {
            this.client = new RestClient(URL_DEEZER);
        }

        public DeezerUser GetProfile(string name)
        {
            var request = new RestRequest($"/search/user?q={name}&limit=50", Method.GET);     
        
            IRestResponse response = client.Execute(request);

            var users = response.Content;    

            return users != null    
            ? JsonConvert.DeserializeObject<DeezerUser>(users) 
            : null;
        }

        public DeezerPlaylist GetPLaylist(string userId)
        {
            var request = new RestRequest($"user/{userId}/playlists?limit=50", Method.GET);

            IRestResponse response = client.Execute(request);

            var playlists = response.Content;

            return playlists != null
            ? JsonConvert.DeserializeObject<DeezerPlaylist>(playlists)
            : null;
        }

        public List<DeezerMusics> GetMusics(string playlistId)
        {
            throw new NotImplementedException();
        }

        public void CreatePlaylit()
        {
            throw new System.NotImplementedException();
        }
    }
}