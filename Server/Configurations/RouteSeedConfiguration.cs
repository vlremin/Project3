using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project3.Shared.Domain;

namespace Project3.Server.Configurations
{
    public class RouteSeedConfiguration : IEntityTypeConfiguration<Route>
    {
        public void Configure(EntityTypeBuilder<Route> builder)
        {
            builder.HasData(
                    new Route
                    {
                        ID = 1,
                        Price = "$8500",
                        NoOfTravellers = "2",
                        LengthOfTrip = "3 days"
                    },
                    new Route
                    {
                        ID = 2,
                        Price = "$9500",
                        NoOfTravellers = "2",
                        LengthOfTrip = "5 days"
                    }
                    );

        }


    }
}
