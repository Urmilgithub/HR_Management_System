﻿using HR_Management_API.Models.Domain;

namespace HR_Management_API.Repository
{
    public interface IStateRepository
    {
       Task<List<State>> GetAllStates();
       Task<State?> GetStateById(int id);
       Task<State> AddStates(State state);
       Task<State?> UpdateState(int id, State state);
       Task<State?> DeleteStateById(int id);

    }
}
