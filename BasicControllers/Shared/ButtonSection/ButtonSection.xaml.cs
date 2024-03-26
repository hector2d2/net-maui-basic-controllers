namespace BasicControllers.Shared.ButtonSection;

public partial class ButtonSection : ContentView
{
	public static readonly BindableProperty TitleProperty = BindableProperty.Create(
	   nameof(Title),
	   typeof(string),
	   typeof(ButtonSection),
	   ""
	 );

	public string Title
	{
		get => (string)GetValue(TitleProperty);
		set => SetValue(TitleProperty, value);
	}

	public static readonly BindableProperty RouteNameProperty = BindableProperty.Create(
	   nameof(RouteName),
	   typeof(string),
	   typeof(ButtonSection),
	   ""
	 );

	public string RouteName
	{
		get => (string)GetValue(RouteNameProperty);
		set => SetValue(RouteNameProperty, value);
	}

	public ButtonSection()
	{
		InitializeComponent();
	}

	void OnbtnSectionGestureRecognizerTapped(object sender, TappedEventArgs args)
	{
		Shell.Current.GoToAsync($"//{RouteName}");
	}
}