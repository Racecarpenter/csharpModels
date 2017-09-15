using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using exampleApi.Models;

namespace exampleApi
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
            services.AddDbContext<UserContext>(opt => opt.UseInMemoryDatabase());
			services.AddMvc();
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseMvc();
		}
	}
}