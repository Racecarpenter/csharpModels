using System;
using Microsoft.EntityFrameworkCore;
namespace exampleApi.Models
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) 
            : base(options)
        {
        }
		public DbSet<User> Users { get; set; }

	}
}
