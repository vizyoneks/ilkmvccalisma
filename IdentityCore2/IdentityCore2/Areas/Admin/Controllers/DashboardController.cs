﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace IdentityCore2.Areas.Admin.Controllers
{
    
    public class DashboardController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}