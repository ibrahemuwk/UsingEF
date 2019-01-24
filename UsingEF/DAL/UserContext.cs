using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using UsingEF.Models;

namespace UsingEF.DAL
{
    public class UserContext : DbContext
    {
        public UserContext() : base()
        {
        }
        public DbSet<User> Users { get; set; }
       
    }
}