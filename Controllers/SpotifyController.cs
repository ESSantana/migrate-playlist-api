using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PlaylistApi.Domain.Entities;
using PlaylistApi.Models.ViewModel;

namespace PlaylistApi.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class SpotifyController : ControllerBase
    {
        private readonly IMapper mapper;
        public SpotifyController(IMapper mapper)
        {
            this.mapper = mapper;
        }

        [HttpGet]
        // [AuthorizeAttribute()]
        public ActionResult<List<SpotifyPlaylistViewModel>> Get()
        {
            return null;            
        }
    }
}