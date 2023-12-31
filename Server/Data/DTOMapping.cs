﻿using AutoMapper;
using Core.Models;

namespace Server.Data;
internal sealed class DTOMapping : Profile {
    public DTOMapping() {
        CreateMap<SectionModel, SectionDTO>().ReverseMap();
        CreateMap<SurveyModel, SurveyDTO>().ReverseMap();
        CreateMap<QuestionModel, QuestionDTO>().ReverseMap();
        CreateMap<QuestionOptionModel, QuestionOptionDTO>().ReverseMap();
    }
}

