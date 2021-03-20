using AutoMapper;
using MusicMarket.Api.DTO;
using MusicMarket.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicMarket.Api.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Domain to Resource
            CreateMap<Music, BookDTO>();
            CreateMap<Artist, LibraryDTO>();

            // Resource to Domain
            CreateMap<BookDTO, Music>();
            CreateMap<LibraryDTO, Artist>();

            CreateMap<SaveBookDTo, Music>();
            CreateMap<SaveLibraryDTO, Artist>();
        }
    }
}
