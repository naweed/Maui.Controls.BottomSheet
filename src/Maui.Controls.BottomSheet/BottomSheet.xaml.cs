using Microsoft.Maui;
using Microsoft.VisualBasic;

namespace XGENO.Maui.Controls;

public partial class BottomSheet : ContentView
{
    private const uint shortDuration = 500;

    public IList<Microsoft.Maui.IView> BottomSheetContent => BottomSheetContentGrid.Children;

    #region Bindable Properties

    public static readonly BindableProperty SheetHeightProperty = BindableProperty.Create(
        nameof(SheetHeight),
        typeof(double),
        typeof(BottomSheet),
        300d,
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is BottomSheet sheet && newValue != oldValue)
            {
                sheet.BottomSheetRowDefinition.Height = ((double)newValue);
                sheet.MainContent.TranslationY = ((double)newValue);
            }
        });

    public double SheetHeight
    {
        get => (double)GetValue(SheetHeightProperty);
        set => SetValue(SheetHeightProperty, value);
    }

    #endregion

    public BottomSheet()
	{
		InitializeComponent();
	}

	public async Task OpenBottomSheet()
    {
        
        BackgroundFader.IsVisible = true;
        _ = BackgroundFader.FadeTo(1, shortDuration, Easing.SinInOut);
        await MainContent.TranslateTo(0, 0, shortDuration, Easing.SinInOut);

        //AnimateClosePopupButton(ClosePopupPaneButton, entering: true);
    }

    public async Task CloseBottomSheet()
    {
        await Task.CompletedTask;
    }
}
