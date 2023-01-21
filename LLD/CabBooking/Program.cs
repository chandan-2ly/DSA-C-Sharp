using CabBooking.RepositoryLayer;
using CabBooking.Service;
using CabBooking.Strategies;

namespace CabBooking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            //register the classes and injected interfaces
            builder.Services.AddSingleton<ICabService, CabService>();
            builder.Services.AddSingleton<ICabRepository, HashMapBasedCabStorgae>();

            builder.Services.AddSingleton<IRiderService, RiderService>();
            builder.Services.AddSingleton<IRiderRepository, HashMapBasedRiderStorage>();

            builder.Services.AddSingleton<ITripService, TripService>();
            builder.Services.AddSingleton<ITripRepository, TripRepository>();

            builder.Services.AddSingleton<ICabMatchingStrategy, DefaultCabMatchingStrategy>();
            builder.Services.AddSingleton<IPricingStrategy, DefaultPricingStrategy>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}