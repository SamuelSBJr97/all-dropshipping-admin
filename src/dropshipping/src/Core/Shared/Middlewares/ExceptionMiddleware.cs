using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System;
using System.Net;

namespace DropshippingAdmin.Core.Shared.Middlewares
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;
        public ExceptionMiddleware(RequestDelegate next) => _next = next;

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                await context.Response.WriteAsync($"Error: {ex.Message}");
            }
        }
    }
}
