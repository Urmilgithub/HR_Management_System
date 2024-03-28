using Microsoft.EntityFrameworkCore;

namespace HR_Management_API.DBContext
{
    public class Data_DBContext: DbContext
    {
        public Data_DBContext(DbContextOptions<Data_DBContext> dbContextOptions) : base(dbContextOptions)
        {

        }
    }
}
