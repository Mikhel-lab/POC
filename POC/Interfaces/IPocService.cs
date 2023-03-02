using POC.Models.FactoryEntity;
using POC.Models.LGAEntity;
using POC.Models.PocEntity;
using POC.Models.StateEntity;
using POC.Response;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace POC.Interfaces
{
    public interface IPocService
    {
        Task AddPoc(Poc poc);
        Task AddState(State st);
        //Task AddCar(Car car);
        Task<PocResponse<List<FactoryLocation>>> getAllFactoryLocations();
        Task<PocResponse<List<LGA>>> getAllLGA();
        Task<PocResponse<List<State>>> getAllState();
    }
}