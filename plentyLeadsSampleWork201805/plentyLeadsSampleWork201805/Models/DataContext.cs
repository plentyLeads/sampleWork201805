using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace plentyLeadsSampleWork201805.Models
{
    public class DataContext : DbContext
    {
        public DataContext()
            : base("DataContext")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<SocialMediaChannel> SocialMediaChannels { get; set; }
    }
}