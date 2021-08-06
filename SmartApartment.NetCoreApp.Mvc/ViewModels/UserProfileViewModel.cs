﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartApartment.NetCoreApp.Mvc.ViewModels
{
    public class UserProfileViewModel
    {
        public string Country { get; set; }

        public string EmailAddress { get; set; }

        public string Name { get; set; }

        public string ProfileImage { get; set; }
    }
}
