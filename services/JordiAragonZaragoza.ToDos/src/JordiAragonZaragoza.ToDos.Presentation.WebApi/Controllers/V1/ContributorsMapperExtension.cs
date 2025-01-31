﻿namespace JordiAragonZaragoza.ToDos.Presentation.WebApi.Controllers.V1
{
    using System.Collections.Generic;
    using Ardalis.Result;
    using JordiAragon.SharedKernel.Application.Contracts;
    using JordiAragon.SharedKernel.Presentation.WebApi.Contracts;
    using JordiAragonZaragoza.ToDos.Application.Contracts.Features.Contributors.Commands;
    using JordiAragonZaragoza.ToDos.Application.Contracts.Features.Contributors.Queries;
    using JordiAragonZaragoza.ToDos.Presentation.WebApi.Contracts.V1.Contributors.Requests;
    using JordiAragonZaragoza.ToDos.Presentation.WebApi.Contracts.V1.Contributors.Responses;
    using JordiAragonZaragoza.ToDos.Presentation.WebApi.Mappers.V1;

    public static class ContributorsMapperExtension
    {
        public static void MapContributor(this Mapper maps)
        {
            // Requests to queries or commands.
            maps.CreateMap<CreateContributorRequest, CreateContributorCommand>();
            maps.CreateMap<UpdateContributorRequest, UpdateContributorCommand>();
            maps.CreateMap<GetContributorsPaginatedRequest, GetContributorsPaginatedQuery>();

            // OutputDtos to responses.
            maps.CreateMap<ContributorOutputDto, ContributorResponse>();
            maps.CreateMap<Result<ContributorOutputDto>, Result<ContributorResponse>>();
            maps.CreateMap<Result<IEnumerable<ContributorOutputDto>>, Result<IEnumerable<ContributorResponse>>>();
            maps.CreateMap<PaginatedCollectionOutputDto<ContributorOutputDto>, PaginatedCollectionResponse<ContributorResponse>>();
            maps.CreateMap<Result<PaginatedCollectionOutputDto<ContributorOutputDto>>, Result<PaginatedCollectionResponse<ContributorResponse>>>();
        }
    }
}