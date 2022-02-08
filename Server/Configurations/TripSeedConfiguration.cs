using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project3.Shared.Domain;

namespace Project3.Server.Configurations
{
    public class TripSeedConfiguration : IEntityTypeConfiguration<Trip>
    {
        public void Configure(EntityTypeBuilder<Trip> builder)
        {
            builder.HasData(
                    new Trip
                    {
                        ID = 1,
                        Details = "To and from Australia"
                    },
                    new Trip
                    {
                        ID = 2,
                        Details = "To and from United Kingdom"
                    }
                    );

        }
    }
}
