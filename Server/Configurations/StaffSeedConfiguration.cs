using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project3.Shared.Domain;

namespace Project3.Server.Configurations
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                    new Staff
                    {
                        ID = 1,
                        StaffID = 4990,
                        StaffPassword = "strongpasswrd",
                        StaffEmail = "nedflanders@gmail.com"
                    },
                    new Staff
                    {
                        ID = 2,
                        StaffID = 8790,
                        StaffPassword = "w34kpasswrd",
                        StaffEmail = "marge@gmail.com"
                    }
                    );

        }
    }
}
