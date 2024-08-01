﻿using Azure.Core;
using LlanoApp.Api.Commands;
using LlanoApp.Api.Dto;
using LlanoApp.Api.Queries;
using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LlanoApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ResourceController(IMediator mediator )
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<bool> Create([FromBody] CreateResourceDto createResourceDto) 
        {
          var command = new CreateResourceCommand(createResourceDto);
          var result = await _mediator.Send(command);
          return result;  
        }

        [HttpGet]
        public Task<List<Resource>> GetAll()
        {
               var listResources =  _mediator.Send(new GetAllListResourcesQuery());
            return listResources;
        }
    }
}
