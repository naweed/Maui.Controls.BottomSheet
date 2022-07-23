using TestApp.MockData;

namespace TestApp;

public partial class MainPage : ContentPage
{
    public List<Movie> Movies { get; set; }

	public MainPage()
	{
		InitializeComponent();

        Movies = MoviesService.GetMovies();

        BindingContext = this;
    }

	async void SimpleBottomSheetButton_Clicked(System.Object sender, System.EventArgs e) =>
		await simpleBottomSheet.OpenBottomSheet();

    async void CustomBottomSheetButton_Clicked(System.Object sender, System.EventArgs e) =>
        await customBottomSheet1.OpenBottomSheet();

    async void CustomBottomSheetButton2_Clicked(System.Object sender, System.EventArgs e) =>
        await customBottomSheet2.OpenBottomSheet();

    async void CustomBottomSheetButton3_Clicked(System.Object sender, System.EventArgs e) =>
        await customBottomSheet3.OpenBottomSheet();

    async void CustomBottomSheetButton4_Clicked(System.Object sender, System.EventArgs e) =>
        await customBottomSheet4.OpenBottomSheet();

    async void CloseMe_Clicked(System.Object sender, System.EventArgs e) =>
        await customBottomSheet3.CloseBottomSheet();

    async void DarkBottomSheet_Clicked(System.Object sender, System.EventArgs e) =>
        await darkBottomSheet.OpenBottomSheet();

    async void lstMovies_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
    {
        var selectedMovie = e.CurrentSelection.First() as Movie;
        await customBottomSheet4.CloseBottomSheet();
        await DisplayAlert("Selected Movie", $"You selected \"{selectedMovie.Title}\" from Year {selectedMovie.Year}. It was a great movie. Right?", "Yes, it was!");
    }
}


