using Ecommerce.Data;

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

        CollectionListView.ItemsSource = ShoesData.ShoesList;
    }
}