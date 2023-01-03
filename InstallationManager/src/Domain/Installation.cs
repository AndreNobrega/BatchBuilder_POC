using System.Collections.Generic;
using Domain.IisConfiguration;

namespace Domain
{
	public class Installation
	{
		public IisConfiguration.IisConfiguration IisConfiguration { get; set; }
		public List<Tenant> Tenants { get; set; }
	}
}
