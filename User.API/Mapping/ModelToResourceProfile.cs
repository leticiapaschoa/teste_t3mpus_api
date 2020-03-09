using AutoMapper;
using User.API.Core.Domain.Models;
using User.API.Gateway.Resource;

namespace User.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Elderly, ElderlyResource>();
            CreateMap<Caregiver, CaregiverResource>();
        }
    }
}