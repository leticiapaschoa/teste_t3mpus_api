using System.Collections.Generic;
using System.Linq;
using User.API.Core.Domain.Models;
using User.API.Core.Interfaces.Repositories;

namespace User.API.Gateway.Repositories
{
    public class ElderlyRepository : IElderlyRepository
    {     
        public List<Elderly> GetElderlies()
        {
            return SelectElderlies();
        }

        public Elderly SearchByName(string name){

            return SelectElderlies().FirstOrDefault(e=> e.Name == name);
        }

        //Excluir Mock:
        private List<Elderly> SelectElderlies(){
            var elderlies = new List<Elderly>();

            var elderly1 = new Elderly{
                Id = 100,
                Name = "Leticia",
                NickName = "Le Paschoa"
            };

            var elderly2 = new Elderly{
                Id = 101,
                Name = "Alice Maria",
                NickName = "Alice"
            };
            
            elderlies.Add(elderly1);
            elderlies.Add(elderly2);


            return elderlies;
        }
    }
}