namespace Portfolio.Data.Database;

public class PortfolioContext : DbContext
{
    public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
    {
    }

    public DbSet<BlogPost> BlogPosts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configure your entity mappings here
        modelBuilder.Entity<BlogPost>().ToTable("BlogPosts");
    }
}