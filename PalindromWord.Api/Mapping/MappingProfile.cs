using AutoMapper;
using PalindromWord.Api.Dto;
using PalindromWord.Domain;
namespace PalindromWord.Api.Mapping
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<PalindromeWord, PalindromeDtoForRead>().ReverseMap();
            CreateMap<PalindromeWord, PalindromeDtoForCreate>().ReverseMap();
        }

    }

}
