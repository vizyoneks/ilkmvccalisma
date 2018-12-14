using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspnetCoreMiddleWares.Middlewares
{
    public class AuthControlMiddleware
    {
        private readonly RequestDelegate _next;

        public AuthControlMiddleware(RequestDelegate next)
        {
            this._next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            if(context.Request.Path=="/admin" && !context.User.Identity.IsAuthenticated)
            {
                await context.Response.WriteAsync("Yetkiniz yok");
            }
        }
    }

    public static class AuthControlMiddlewareExtension
    {
        public static IApplicationBuilder UseAuthControl(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<AuthControlMiddleware>();
        }
    }
}
