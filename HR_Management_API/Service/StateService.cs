﻿using HR_Management_API.DBContext;
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

        public async Task<State> AddStates(State state)
        {
           await dBContext.States.AddAsync(state);
           await dBContext.SaveChangesAsync();
           return state;
        }

        public async Task<State?> DeleteStateById(int id)
        {
            var stateDomain = await dBContext.States.FirstOrDefaultAsync(x => x.StateId == id);
            if(stateDomain == null)
            {
                return null;
            }
            dBContext.States.Remove(stateDomain);
            await dBContext.SaveChangesAsync();
            return stateDomain;
        }

        public async Task<List<State>> GetAllStates()
        {
            return await dBContext.States.ToListAsync();
        }

        public async Task<State?> GetStateById(int id)
        {
            return await dBContext.States.FirstOrDefaultAsync(x => x.StateId == id);
        }

        public async Task<State?> UpdateState(int id, State state)
        {
            var stateDomain = await dBContext.States.FirstOrDefaultAsync(x => x.StateId == id);
            if(stateDomain == null)
            {
                return null;
            }
            stateDomain.StateId = state.StateId;
            stateDomain.StateName = state.StateName;

            await dBContext.SaveChangesAsync();
            return stateDomain;

        }
    }
}
