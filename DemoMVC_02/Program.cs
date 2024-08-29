namespace DemoMVC_02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

          app.UseStaticFiles();

            app.UseRouting();
            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(

                    name: "deafult",
                    pattern: "/{controller=Home}/{action=Index}",
                    defaults: new
                    {
                        controller = "Home",action = "Index"
                    }
                    );

                //endpoints.MapControllerRoute(

                //    name: "deafult",
                //    pattern: "/{controller=Home}/{action=AboutUs}",
                //    defaults: new
                //    {
                //        controller = "Home",
                //        action = "AboutUs"
                //    }
                //    );





                #region MyRegion
                //app.MapGet("/", () => "Hello World!")
                //app.UseRouting();
                //app.Use(async (context, next) =>

                //{
                //    Endpoint endpoint = context.GetEndpoint();
                //    if (endpoint != null)
                //    {
                //        await context.Response.WriteAsync(endpoint.DisplayName);
                //    }
                //    await next(context);
                //}

                //); 
                #endregion
                #region MyRegion
                //endpoints.Map("/Home", async (context) =>
                //{
                //    await context.Response.WriteAsync("You Are In Home Page");
                //});

                //endpoints.MapGet("/Product/{id?}", async (context) =>
                //{
                //    var id = context.Request.RouteValues ["id"];
                //    if (id != null)
                //    {
                //        id = Convert.ToInt32(context.Request.RouteValues["id"]);
                //    }
                //    else
                //        await context.Response.WriteAsync($"You Are In Product Page with {id}");
                //});
                //endpoints.MapGet("/Books/Author/{authorname}/{bookid}", async (context) =>

                //{
                //    var bookid = Convert.ToInt32(context.Request.RouteValues["bookid "]);
                //    var authorname = Convert.ToString(context.Request.RouteValues["authorname"]);
                //    await context.Response.WriteAsync($"You Are In Product Page with {bookid} and Author {authorname}");
                //});

                //    endpoints.MapPost("/Post", async (context) =>
                //    {
                //        await context.Response.WriteAsync("You Are In post Page");
                //    });

                #endregion
                #region MyRegion
                //});
                //app.Run(async (HttpContext context) =>
                //{
                //    await context.Response.WriteAsync("The page that you are requesting ");
                //}); 
                #endregion

            });
            app.Run();


            
        }
    }
}
