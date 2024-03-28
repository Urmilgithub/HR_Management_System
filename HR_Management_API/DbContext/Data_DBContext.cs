using Microsoft.EntityFrameworkCore;

namespace hr_management_api.dbcontext
{
    public class data_dbcontext : DbContext
    {
        public data_dbcontext(DbContextOptions dbcontextoptions) : base(dbcontextoptions)
        {
        }

    }
}
