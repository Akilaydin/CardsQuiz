using UnityEngine;

using VContainer;
using VContainer.Unity;

public class GameLifetimeScope : LifetimeScope
{
	[SerializeField]
	private HelloScreen _helloScreen;
	
	protected override void Configure(IContainerBuilder builder)
	{
		builder.RegisterEntryPoint<GamePresenter>();

		builder.Register<HelloWorldService>(Lifetime.Singleton);

		builder.RegisterComponent(_helloScreen);
	}
}

