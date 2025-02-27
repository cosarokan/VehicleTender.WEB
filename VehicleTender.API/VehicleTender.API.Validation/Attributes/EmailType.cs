﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTender.API.Validation.Attributes
{
    public enum EmailValidateType
    {
        Education = 1,
        Government = 2,
        Gmail = 3,
        Hotmail = 4,
        Outlook = 5,
        Syntax = 6,
        General= 7,
    }
    [AttributeUsage(AttributeTargets.All)]
    public class EmailType : Attribute
    {
        public EmailType()
        {

        }
        public EmailValidateType EmailValidateType { get; set; }
    }
}
