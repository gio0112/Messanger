using DataLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Contexts
{
    public class SessionsContext : DbContext
    {
        public SessionsContext(DbContextOptions<SessionsContext> option) : base(option)
        {

        }

        public DbSet<Session> Sessions { get; set; }
    }
}
