using VContainer.Unity;

public class GamePresenter : IStartable //Здесь связывается отображение и функционал. Невероятно!
{
	private readonly HelloWorldService _helloWorldService;

	private readonly HelloScreen _helloScreen;
	
	public GamePresenter(HelloWorldService helloWorldService, HelloScreen helloScreen)
	{
		_helloWorldService = helloWorldService;
		_helloScreen = helloScreen;
	}
	
	void IStartable.Start()
	{
		_helloScreen.HelloButton.onClick.AddListener(() => _helloWorldService.Hello());
	}
}

