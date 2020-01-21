using Microsoft.EntityFrameworkCore;

namespace WebSearchAggregator.Database
{
    class AggregatorContext : DbContext
    {
        public AggregatorContext(DbContextOptions options) : base(options)
        {
        }
    }
}
