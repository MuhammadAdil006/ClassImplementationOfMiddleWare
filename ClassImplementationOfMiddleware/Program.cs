using ClassImplementationOfMiddleware;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.MapGet("/", () => "Hello World!");
app.UseMiddleware<Mymiddleware>();
app.Use(async (context, next) =>
{
    context.Response.ContentType="text/plain";
    await context.Response.WriteAsync("\n hwllow another string");
    await next();
});
app.Run();
