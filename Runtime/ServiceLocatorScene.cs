using UnityEngine;

namespace AeLa.Utilities
{
	[AddComponentMenu("ServiceLocator/ServiceLocator Scene")]
	public class ServiceLocatorScene : Bootstrapper
	{
		protected override void Bootstrap()
		{
			Container.ConfigureForScene();
		}
	}
}