using System;
using System.Collections.Generic;

namespace User.API.Gateway.Resource
{
    public class ElderlyResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string NickName { get; set; }
        public DateTime BornDate { get; set; }
        public string BloodType { get; set; }

        public IList<CaregiverResource> Caregivers { get; set; } = new List<CaregiverResource>();
    }
}