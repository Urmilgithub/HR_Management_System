using HR_Management_API.DBContext;
using HR_Management_API.Models.Domain;
using HR_Management_API.Repository;
using Microsoft.EntityFrameworkCore;

namespace HR_Management_API.Service
{
    public class StateService : IStateRepository
    {
        private readonly Data_DBContext dBContext;

        public StateService(Data_DBContext _dBContext)
        {
            dBContext = _dBContext;
        }


        public async Task<List<State>> GetAllStates()
        {
            return await dBContext.States.ToListAsync();
        }
    }
}
