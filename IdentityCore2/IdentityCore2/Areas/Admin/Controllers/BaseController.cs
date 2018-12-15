using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace IdentityCore2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BaseController : Controller
    {
        public BaseController()
        {
            //string customerKey = "customer";
            //string customerKey = "session.customer:1455";
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var actionName = context.ActionDescriptor.DisplayName;


            base.OnActionExecuting(context);
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }
    }
}