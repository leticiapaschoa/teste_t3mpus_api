using System.Collections.Generic;
using System.Threading.Tasks;
using User.API.Core.Domain.Models;

namespace User.API.Core.Interfaces.Services
{
    public interface IElderlyService
    {
         List<Elderly> GetElderlies();
         Elderly SearchByName(string name);
    }
}