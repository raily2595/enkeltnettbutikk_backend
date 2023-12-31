using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using enkeltnettbutikk_backend.Context;

namespace EnkeltNettbutikkBackend
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<NettbutikkDbContext>(options =>
            {
                options.UseMySql(Configuration.GetConnectionString("DefaultConnection"), new MySqlServerVersion(new Version(8, 0, 27))); // Bruk din tilkoblingsstreng her
            });

            services.AddControllers();

            // Legg til CORS-tjenesten
            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:3000") // Endre til din frontend-adresse
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });

            // Legg til Swagger/OpenAPI-dokumentasjon
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Your API", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthorization();

            // Aktiver CORS-policyen
            app.UseCors("AllowSpecificOrigin");

            // Aktiver Swagger UI i utviklingsmodus
            if (app.ApplicationServices.GetRequiredService<IWebHostEnvironment>().IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Your API V1");
                });
            }

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
