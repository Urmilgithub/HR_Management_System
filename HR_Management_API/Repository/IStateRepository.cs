using HR_Management_API.Models.Domain;

namespace HR_Management_API.Repository
{
    public interface IStateRepository
    {
       Task<List<State>> GetAllStates();
    }
}
