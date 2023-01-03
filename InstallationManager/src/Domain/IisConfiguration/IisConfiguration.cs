using System.Collections.Generic;

namespace Domain.IisConfiguration
{
	public class IisConfiguration
	{
		public string Directory { get; set; }
		public List<PortBinding> PortBindings { get; set; }
	}
}
