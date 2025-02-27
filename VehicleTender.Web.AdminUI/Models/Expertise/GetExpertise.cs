﻿using VehicleTender.WEB.Admin.Validation.Attributes;

namespace VehicleTender.Web.AdminUI.Models.Expertise
{
    public class GetExpertise
    {
        public int ExpertiseId { get; set; }
        [StringType(Max =20,Min =1)]
        public string ExpertiseName { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string City { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string District { get; set; }
        public string Telephone { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Address { get; set; }
    }
}
