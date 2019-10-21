using AutoMapper;
using PlaylistApi.Domain.Entities;
using PlaylistApi.Models.ViewModel;

namespace PlaylistApi.AutoMapper.Mappers
{
    public class DeezerUserMapper
    {
        public static void Map(Profile profile)
        {
            profile.CreateMap<DeezerUser, DeezerUserViewModel>();
        }
    }
}