using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project3.Shared.Domain;

namespace Project3.Server.Configurations
{
    public class TravellerSeedConfiguration : IEntityTypeConfiguration<Traveller>
    {
        public void Configure(EntityTypeBuilder<Traveller> builder)
        {
            builder.HasData(
                    new Traveller
                    {
                        ID = 27,
                        TPassword = "Tg510781",
                        TAge = "24",
                        TPhoneNo = "91196242",
                        TEmail = "valerieeoxm@gmail.com"
                    },
                    new Traveller
                    {
                        ID = 48,
                        TPassword = "Tg541178",
                        TAge = "28",
                        TPhoneNo = "85692575",
                        TEmail = "bartsimpson@gmail.com"
                    }
                    );

        }
    }
}
