using System.Collections.Generic;
using System.Threading.Tasks;
using User.API.Core.Domain.Models;

namespace User.API.Core.Interfaces.Repositories
{
    public interface IElderlyRepository
    {
         List<Elderly> GetElderlies();

         Elderly SearchByName(string name);
    }
}