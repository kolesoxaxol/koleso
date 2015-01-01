using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class DataBaseInitializer : DropCreateDatabaseAlways<MainContext>
    {
        protected override void Seed(MainContext context)
        { context.SaveChanges(); }
    }
}
