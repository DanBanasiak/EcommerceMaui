using Ecommerce.Data;
using System.Collections.ObjectModel;

namespace Ecommerce.Pages;

public partial class CollectionPage : ContentPage
{
	public CollectionPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
        base.OnAppearing();

        CollectionListView.ItemsSource = new ObservableCollection<Models.Shoes>(ShoesData.ShoesList);
    }
}