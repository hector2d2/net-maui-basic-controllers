using System.Collections.ObjectModel;
using System.ComponentModel;
namespace BasicControllers.Views.VerticalStackLayoutView;

public partial class VerticalStackLayoutView : ContentPage, INotifyPropertyChanged
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
	// ObservableCollection<int> numeros = new();

	// public ObservableCollection<int> Numeros
	// {
	// 	get => numeros;
	// 	set
	// 	{
	// 		numeros = value;
	// 		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Numeros"));
	// 	}
	// }

	public VerticalStackLayoutView()
	{
		InitializeComponent();

		// List
		for (int i = 0; i < 100; i++)
		{
			numeros.Add(i);
		}
		Numeros = new List<int>(numeros);

		// Observable
		// for (int i = 0; i < 100; i++)
		// {
		// 	Numeros.Add(i);
		// }
	}
}