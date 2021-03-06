﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Helpers
{
    public static class RegexHelpers
    {
        public const string NAME = @"^[a-zA-Z\s]+$";
        public const string NAME_ERROR_MSG = "Use only letters in the name.";

        public const string PHONE = @"^\d{10}$";
        public const string PHONE_ERROR_MSG = "Contact number is invalid, must be 10 digits long.";

        public const string EMAIL = @"^[\d\w\._\-]+@([\d\w\._\-]+\.)+[\w]+$";
        public const string EMAIL_ERROR_MSG = "Email is invalid.";

        public const string POST_CODE = @"^\d{4}$";
        public const string POST_CODE_ERROR_MSG = "Postcode is invalid, must be 4 digits long.";
    }
}
