using System;
using System.Collections.Generic;
using User.API.Core.Domain.Enum;

namespace User.API.Core.Domain.Models
{
    public class Elderly
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public DateTime BornDate { get; set; }
        public EBloodType BloodType { get; set; }

        public IList<Caregiver> Caregivers { get; set; } = new List<Caregiver>();
    }
}