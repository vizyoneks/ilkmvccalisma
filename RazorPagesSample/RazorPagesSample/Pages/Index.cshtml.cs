﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesSample.Pages
{
    public class IndexModel : PageModel
    {
        public int OnlineUserCount { get; set; }

        public void OnGet()
        {
            OnlineUserCount = 285;
        }
    }
}
