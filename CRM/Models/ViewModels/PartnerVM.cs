﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Models.ViewModels
{
    public class PartnerVM : Partner
    {
        public int[] Services { set; get; }
    }
}
