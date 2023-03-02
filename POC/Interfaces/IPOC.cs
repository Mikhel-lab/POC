using POC.Models.FactoryEntity;
using POC.Models.LGAEntity;
using POC.Models.PocEntity;
using POC.Models.StateEntity;
using POC.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POC.Interfaces
{
    public interface IPOC
    {
        Task<PocResponse<List<State>>> getAllState();
        Task<PocResponse<List<LGA>>> getAllLGA();
        Task AddPoc(Poc poc);
        Task AddState(State stat);
        Task<PocResponse<List<FactoryLocation>>> getAllFactoryLocations();
    }
}
