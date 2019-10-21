using System.Collections.Generic;
using PlaylistApi.Domain.Entities;

namespace PlaylistApi.Models.ViewModel
{
    public class DeezerUserViewModel
    {
        public List<User> Users { get; set; } 
        public int Total { get; set; }
        public string Next { get; set; }
    }
}