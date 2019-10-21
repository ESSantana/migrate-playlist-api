using System;
using System.Collections.Generic;
using PlaylistApi.Domain.Entities;
using PlaylistApi.Repository;

namespace PlaylistApi.Services
{
    public class DeezerService : IDeezerService
    {

        private readonly IDeezerRepository deezerRepository;

        public DeezerService (IDeezerRepository deezerRepository)
        {
            this.deezerRepository = deezerRepository;
        }

        public DeezerUser GetProfile(string name)
        {
            var result = deezerRepository.GetProfile(name);

            if(result == null)
            {
                throw new System.Exception("Usuário não encontrado");
            }
        
            return result;
        }

        public DeezerPlaylist GetPlaylist(string userId)
        {       
            var result = deezerRepository.GetPLaylist(userId);

            if(result == null)
            {
                throw new System.Exception("Nenhuma playlist encontrada");
            }

            return result;
        }

        public List<DeezerMusics> GetMusics(string playlistId)
        {       
            throw new NotImplementedException();
        }

        public void CreatePlaylist()
        {
            throw new NotImplementedException();
        }

    }
}