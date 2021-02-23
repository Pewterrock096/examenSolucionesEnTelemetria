using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1.DataContext
{
    public class dataBaseContext:DbContext
    {
        public dataBaseContext():base(nameOrConnectionString: "Postgres")
        {

        }

        public virtual DbSet<empleado> empleadoObj { get; set; }
    }
}