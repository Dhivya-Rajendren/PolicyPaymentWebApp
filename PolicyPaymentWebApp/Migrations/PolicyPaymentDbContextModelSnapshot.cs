// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PolicyPaymentWebApp.Models;

namespace PolicyPaymentWebApp.Migrations
{
    [DbContext(typeof(PolicyPaymentDbContext))]
    partial class PolicyPaymentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PolicyPaymentWebApp.Models.Policy", b =>
                {
                    b.Property<int>("PolicyNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("PolicyName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PolicyPeriod")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PolicyType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PolicyNumber");

                    b.ToTable("Policies");
                });
#pragma warning restore 612, 618
        }
    }
}
