using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using User.API.Core.Domain.Models;
using User.API.Core.Interfaces.Services;
using User.API.Gateway.Resource;

namespace User.API.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ElderlyController : ControllerBase
    {
        private readonly IElderlyService _elderlyService;
        private readonly IMapper _mapper;
        
        public ElderlyController(IElderlyService elderlyService, IMapper mapper)
        {
            _elderlyService = elderlyService; 
            _mapper = mapper;  
        }

        //https://localhost:5001/api/elderly/getAll
        [HttpGet]
        [Route("getAll")] 
        public List<ElderlyResource> GetAll()
        {
            var elderlies =  _elderlyService.GetElderlies();
            var elderliesResources = _mapper.Map<List<Elderly>, List<ElderlyResource>>(elderlies);

            return elderliesResources;
        }

        //https://localhost:5001/api/elderly/SearchByName?name=Leticia
        [HttpGet]
        [Route("SearchByName")] 
        public ElderlyResource SearchByName(string name)
        {
            var elderly = _elderlyService.SearchByName(name);
            var elderlyResources = _mapper.Map<Elderly, ElderlyResource>(elderly);

            return elderlyResources;
        }
    }
}