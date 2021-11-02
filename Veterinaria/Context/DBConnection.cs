using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Veterinaria.Models;

namespace Veterinaria.Context
{
    public class DBConnection : DbContext
    {
        public
       DBConnection(DbContextOptions<DBConnection> options)
       : base(options)
        {

        }
        public DbSet<Turno> Turnos { get; set; }


    }
    
}



    

