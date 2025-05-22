using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DropshippingAdmin.Core.Shared.Middlewares
{
    public class RequestLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        public RequestLoggingMiddleware(RequestDelegate next) => _next = next;

        public async Task InvokeAsync(HttpContext context)
        {
            var sw = Stopwatch.StartNew();
            await _next(context);
            sw.Stop();
            var log = $"{context.Request.Method} {context.Request.Path} responded {context.Response.StatusCode} in {sw.ElapsedMilliseconds}ms";
            Console.WriteLine(log);
        }
    }
}
