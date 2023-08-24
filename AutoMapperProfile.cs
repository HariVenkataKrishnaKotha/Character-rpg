using AutoMapper;
using Character_rpg.Dtos.Character;

namespace Character_rpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto,Character>();
        }
    }
}
