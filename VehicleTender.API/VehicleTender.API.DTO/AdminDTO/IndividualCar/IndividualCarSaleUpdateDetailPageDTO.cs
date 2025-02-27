﻿using VehicleTender.API.DTO.AdminDTO.Models.Car;
using VehicleTender.API.Validation.Attributes;

namespace VehicleTender.API.DTO.AdminDTO.Models.IndividualCar
{
    public class IndividualCarSaleUpdateDetailPageDTO
    {//araç tarihçe eksik 
        public int CarId { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string MemberNameSurname { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Statu { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string PreAssesmentPrice { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Offer { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CarBrand { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string CarModel { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string BodyType { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Year { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string FuelType { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string TransmissionType { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Version { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string KM { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Color { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Hardware { get; set; }
        public string[] Picture { get; set; }
        [StringType(Max = 20, Min = 1)]
        public string Description { get; set; }
        public double TotalSumTramer { get; set; }
        //public Dictionary<TramerDTO, TramerValueDTO> TramerInformation { get; set; }
        public TramerDTO Tramer { get; set; }
    }
}
