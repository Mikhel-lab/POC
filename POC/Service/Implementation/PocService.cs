using Microsoft.EntityFrameworkCore;
using POC.Interfaces;
using POC.Models.FactoryEntity;
using POC.Models.LGAEntity;
using POC.Models.PocEntity;
using POC.Models.StateEntity;
using POC.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POC.Service.Implementation
{
    public class PocService : IPocService
    {
        private readonly MyDbContext _context;
        public PocService(MyDbContext context)
        {
            _context = context;
        }

        public async Task AddPoc(Poc poc)
        {
            _context.POCS.Add(poc);
            await _context.SaveChangesAsync();
        }

        public async Task AddState(State st)
        {
            _context.States.Add(st);
            await _context.SaveChangesAsync();
        }

      
        public async Task<PocResponse<List<FactoryLocation>>> getAllFactoryLocations()
        {
            var factories = await _context.Factories.ToListAsync();
            if (factories == null)
            {
                return new PocResponse<List<FactoryLocation>>
                {
                    Success = false,
                    Message = "No factories found."
                };
            }
            return new PocResponse<List<FactoryLocation>>
            {
                Success = true,
                Data = factories
            };
        }

        public async Task<PocResponse<List<LGA>>> getAllLGA()
        {
            var lga = await _context.LocalGovernments.ToListAsync();
            if (lga == null)
            {
                return new PocResponse<List<LGA>>
                {
                    Success = false,
                    Message = "No factories found."
                };
            }
            return new PocResponse<List<LGA>>
            {
                Success = true,
                Data = lga
            };
        }

        public async Task<PocResponse<List<State>>> getAllState()
        {
            var states = await _context.States.ToListAsync();
            if (states == null)
            {
                return new PocResponse<List<State>>
                {
                    Success = false,
                    Message = "No State found."
                };
            }
            return new PocResponse<List<State>>
            {
                Success = true,
                Data = states
            };
        }
    }
}
