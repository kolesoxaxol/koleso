using AirModel.Models;
using AirModel.SiteLocalization;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Dispose();
        GenericRepository<AirPlane> AirPlaneRepository { get; set; }
        GenericRepository<City> CityRepository { get; set; }
        GenericRepository<DispatcherRequest> DispatcherRequestRepository { get; set; }
        GenericRepository<Flight> FlightRepository { get; set; }
        GenericRepository<Position> PositionRepository { get; set; }
        GenericRepository<Register> RegisterRepository { get; set; }
        GenericRepository<Role> RoleRepository { get; set; }
        GenericRepository<User> UserRepository { get; set; }
        GenericRepository<Crew> CrewRepository { get; set; }
        GenericRepository<Language> LanguageRepository { get; set; }
        void Save();
        
    }
}
