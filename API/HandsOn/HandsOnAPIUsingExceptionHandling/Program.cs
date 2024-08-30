
namespace HandsOnAPIUsingExceptionHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
           // builder.Services.AddControllers();
            builder.Services.AddControllers(options =>
            options.Filters.Add(new GlobalExceptionFilter()));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

                app.UseDeveloperExceptionPage();
                //app.UseExceptionHandler("/error");
            }
            else
            {
                app.UseExceptionHandler("/production-error");
            }
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}