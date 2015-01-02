using AirModel.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly MainContext _context;

        public UnitOfWork(MainContext context)
        {
            _context = context;
        }

        private GenericRepository<AirPlane> _airPlaneRepository;
        private GenericRepository<City> _cityRepository;
        private GenericRepository<DispatcherRequest> _dispatcherRequestRepository;
        private GenericRepository<Flight> _flightRepository;
        private GenericRepository<Position> _positionRepository;
        private GenericRepository<Register> _registerRepository;
        private GenericRepository<Role> _roleRepository;
        private GenericRepository<User> _userRepository;
        private GenericRepository<Crew> _crewRepository;

        public GenericRepository<AirPlane> AirPlaneRepository
        {
            get { return _airPlaneRepository ?? (_airPlaneRepository = new GenericRepository<AirPlane>(_context)); }
            set
            {
                _airPlaneRepository = value;
            }
        }

        public GenericRepository<City> BanUserRepository
        {
            get { return _cityRepository ?? (_cityRepository = new GenericRepository<City>(_context)); }
            set
            {
                _cityRepository = value;
            }
        }

        public GenericRepository<DispatcherRequest> BanUserRepository
        {
            get { return _dispatcherRequestRepository ?? (_dispatcherRequestRepository = new GenericRepository<DispatcherRequest>(_context)); }
            set
            {
                _dispatcherRequestRepository = value;
            }
        }

        public GenericRepository<Flight> BanUserRepository
        {
            get { return _flightRepository ?? (_flightRepository = new GenericRepository<Flight>(_context)); }
            set
            {
                _flightRepository = value;
            }
        }

        public GenericRepository<Position> BanUserRepository
        {
            get { return _positionRepository ?? (_positionRepository = new GenericRepository<Position>(_context)); }
            set
            {
                _positionRepository = value;
            }
        }

        public GenericRepository<Register> BanUserRepository
        {
            get { return _registerRepository ?? (_registerRepository = new GenericRepository<Register>(_context)); }
            set
            {
                _registerRepository = value;
            }
        }

        public GenericRepository<Role> RoleRepository
        {
            get { return _roleRepository ?? (_roleRepository = new GenericRepository<Role>(_context)); }
            set
            {
                _roleRepository = value;
            }
        }

        public GenericRepository<User> UserRepository
        {
            get { return _userRepository ?? (_userRepository = new GenericRepository<User>(_context)); }
            set
            {
                _userRepository = value;
            }
        }

        public GenericRepository<Crew> BanUserRepository
        {
            get { return _crewRepository ?? (_crewRepository = new GenericRepository<Crew>(_context)); }
            set
            {
                _crewRepository = value;
            }
        }
    }
}
