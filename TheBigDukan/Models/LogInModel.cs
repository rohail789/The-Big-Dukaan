﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheBigDukan.Models
{
    public class LogInModel
    {
        public string Email { get; set; }

        public string Password { get; set; }

        public string ErrorMsg { get; set; }

    }
}