using System.ComponentModel;

namespace MauiApp1;

public partial class HorizontalStackLayoutView : ContentPage,INotifyPropertyChanged
{
	public event PropertyChangedEventHandler PropertyChanged;
	List<int> numeros = new();

	public List<int> Numeros
	{
		get => numeros;
		set
		{
			numeros = value;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Numeros"));
		}
	}
	public HorizontalStackLayoutView()
	{
		InitializeComponent();
	}
}