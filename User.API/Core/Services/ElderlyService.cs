using System.Collections.Generic;
using System.Threading.Tasks;
using User.API.Core.Domain.Models;
using User.API.Core.Interfaces.Repositories;
using User.API.Core.Interfaces.Services;

namespace User.API.Core.Services
{
    public class ElderlyService : IElderlyService
    {
        private readonly IElderlyRepository _elderlyRepository;

        public ElderlyService(IElderlyRepository elderlyRepository)
        {
            this._elderlyRepository = elderlyRepository;
        }

        public List<Elderly> GetElderlies()
        { 
            return _elderlyRepository.GetElderlies();
        }

        public Elderly SearchByName(string name)
        {
            return _elderlyRepository.SearchByName(name);
        }
    }
}