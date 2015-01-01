using AirModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
   public class MainContext : DbContext
    {
        public MainContext()
            : base("MainContext")
        { }
        public IDbSet<AirPlane> AirPlane { get; set; }
        public IDbSet<City> City { get; set; }
        public IDbSet<DispatcherRequest> DispatcherRequest { get; set; }
        public IDbSet<Flight> Flight { get; set; }
        public IDbSet<Position> Position { get; set; }
        public IDbSet<Registr> Registr { get; set; }
        public IDbSet<Role> Role { get; set; }
        public IDbSet<User> User { get; set; }
        public IDbSet<Crew> Crew { get; set; }
    }
}
