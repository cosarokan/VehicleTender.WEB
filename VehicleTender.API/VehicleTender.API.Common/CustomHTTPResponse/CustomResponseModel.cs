﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Common.CustomHTTPResponse
{
    //public class CustomResponseModel<T>: IDisposable where T : class
    public class CustomResponseModel : IDisposable
    {
        public StatusGenerator GetResponseStatusWhatDoYouWant_CustomStatuOrDefinedStatus { get; set; }
        //public T ResponseData { get; set; } //sil
        //public List<T> ListResponseData { get; set; } //sil
        public string ResponseDataString { get; set; }
        public string Description { get; set; }
        //stringe çevir
        //note alanı ekle
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
