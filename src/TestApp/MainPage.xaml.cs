namespace TestApp;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	async void SimpleBottomSheetButton_Clicked(System.Object sender, System.EventArgs e) =>
		await simpleBottomSheet.OpenBottomSheet();
}


