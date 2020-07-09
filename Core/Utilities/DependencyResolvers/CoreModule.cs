using Core.Utilities.CrossCuttingConcerns.Caching;
using Core.Utilities.CrossCuttingConcerns.Caching.Microsoft;
using Core.Utilities.IoC;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.DependencyResolvers
{
	public class CoreModule : ICoreModule
	{
		public void Load(IServiceCollection services)
		{
			services.AddMemoryCache();
			services.AddSingleton<ICacheManager, MemoryCache>();
		}
	}
}
