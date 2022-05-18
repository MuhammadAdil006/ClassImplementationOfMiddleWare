namespace ClassImplementationOfMiddleware
{
    public class Mymiddleware
    {
        RequestDelegate next;
        public Mymiddleware(RequestDelegate nextd)
        {
            this.next = nextd;
        }

        public async Task Invoke(HttpContext context)
        {
            if(context.Request.Path=="/short")
            {
               await context.Response.WriteAsync("path has been short");
            }
            else
            {
               await next(context);
            }
        }
    }
}
