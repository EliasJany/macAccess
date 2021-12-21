namespace macAccess.DB;

    public class MacAccessContext: DbContext
    {
        public MacAccessContext(DbContextOptions<MacAccessContext> options) : base(options) { }

        public DbSet<MacMini> MacMinis => Set<MacMini>();
        public DbSet<MacMiniData> MacMiniDatas => Set<MacMiniData>();

        protected override void OnModelCreating(ModelBuilder builder)
        {
        }
    }

