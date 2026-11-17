using Microsoft.EntityFrameworkCore;

public class ChuThiNgocYen_KTPMK22C_B6_Ver2Context(DbContextOptions<ChuThiNgocYen_KTPMK22C_B6_Ver2Context> options) : DbContext(options)
{
    public DbSet<ChuThiNgocYen_KTPMK22C_B6_Ver2.Models.Movie> Movie { get; set; } = default!;
    public DbSet<ChuThiNgocYen_KTPMK22C_B6_Ver2.Models.Genre> Genre { get; set; } = default!;
}
