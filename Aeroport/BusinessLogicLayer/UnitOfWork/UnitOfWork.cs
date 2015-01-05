using AirModel.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
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

        public GenericRepository<City> CityRepository
        {
            get { return _cityRepository ?? (_cityRepository = new GenericRepository<City>(_context)); }
            set
            {
                _cityRepository = value;
            }
        }

        public GenericRepository<DispatcherRequest> DispatcherRequestRepository
        {
            get { return _dispatcherRequestRepository ?? (_dispatcherRequestRepository = new GenericRepository<DispatcherRequest>(_context)); }
            set
            {
                _dispatcherRequestRepository = value;
            }
        }

        public GenericRepository<Flight> FlightRepository
        {
            get { return _flightRepository ?? (_flightRepository = new GenericRepository<Flight>(_context)); }
            set
            {
                _flightRepository = value;
            }
        }

        public GenericRepository<Position> PositionRepository
        {
            get { return _positionRepository ?? (_positionRepository = new GenericRepository<Position>(_context)); }
            set
            {
                _positionRepository = value;
            }
        }

        public GenericRepository<Register> RegisterRepository
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

        public GenericRepository<Crew> CrewRepository
        {
            get { return _crewRepository ?? (_crewRepository = new GenericRepository<Crew>(_context)); }
            set
            {
                _crewRepository = value;
            }
        }

        public void Save()
        {
            _context.SaveChanges();
          
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();

                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
