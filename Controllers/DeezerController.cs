using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PlaylistApi.Domain.Entities;
using PlaylistApi.Services;
using System.Linq;
using System.Collections.Generic;
using PlaylistApi.Models.ViewModel;

namespace PlaylistApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class DeezerController : ControllerBase
    {
        private readonly IDeezerService deezerService;
        private readonly IMapper mapper;
    
        public DeezerController(IDeezerService deezerService, IMapper mapper)
        {
            this.deezerService = deezerService;
            this.mapper = mapper;
        }
    
        [HttpGet("user/{username}")]
        public ActionResult<DeezerUserViewModel> GetProfile(string username)
        {
            var result = deezerService.GetProfile(username);

            return result != null ? (ActionResult)Ok(mapper.Map<DeezerUserViewModel>(result)): NoContent();
        }

        [HttpGet("playlist/{userId}")]
        public ActionResult<DeezerPlaylistViewModel> GetPlaylist(string userId)
        {
            var result = deezerService.GetPlaylist(userId);

            return result != null ? (ActionResult)Ok(mapper.Map<DeezerPlaylistViewModel>(result)): NoContent();
        }

        [HttpGet("playlistMusics/{playlistId}")]
        public ActionResult<List<DeezerMusics>> GetMusics(string playlistId)
        {
            var result = deezerService.GetMusics(playlistId);

            return result != null ? (ActionResult)Ok(result.Select(r => mapper.Map<DeezerMusics>(r)).ToList()): NoContent();
        }

        [HttpGet]
        public ActionResult CreatePlaylist(string username)
        {
            return (ActionResult)Ok(null);
        }
    }
}