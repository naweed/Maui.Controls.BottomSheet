namespace XGENO.Maui.Controls;

public partial class BottomSheet : ContentView
{
    public IList<Microsoft.Maui.IView> BottomSheetContent => BottomSheetContentGrid.Children;

    public BottomSheet()
	{
		InitializeComponent();
	}

	public async Task OpenBottomSheet()
    {
        await Task.CompletedTask;
    }

    public async Task CloseBottomSheet()
    {
        await Task.CompletedTask;
    }
}
