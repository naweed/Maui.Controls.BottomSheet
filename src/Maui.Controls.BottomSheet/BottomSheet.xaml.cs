namespace XGENO.Maui.Controls;

public partial class BottomSheet : ContentView
{
    private const uint shortDuration = 250u;
    private const uint regularDuration = shortDuration * 2u;

    public IList<Microsoft.Maui.IView> BottomSheetContent => BottomSheetContentGrid.Children;

    #region Bindable Properties

    public static readonly BindableProperty SheetHeightProperty = BindableProperty.Create(
        nameof(SheetHeight),
        typeof(double),
        typeof(BottomSheet),
        360d,
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

    public static readonly BindableProperty HeaderTextProperty = BindableProperty.Create(
        nameof(HeaderText),
        typeof(string),
        typeof(BottomSheet),
        string.Empty,
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is BottomSheet sheet && newValue != oldValue)
            {
                sheet.HeaderLabel.Text = ((string)newValue);
            }
        });

    public string HeaderText
    {
        get => (string)GetValue(HeaderTextProperty);
        set => SetValue(HeaderTextProperty, value);
    }

    public static readonly BindableProperty HeaderStyleProperty = BindableProperty.Create(
        nameof(HeaderStyle),
        typeof(Style),
        typeof(BottomSheet),
        null,
        BindingMode.OneWay,
        validateValue: (_, value) => value != null,
        propertyChanged:
        (bindableObject, oldValue, newValue) =>
        {
            if (newValue is not null && bindableObject is BottomSheet sheet && newValue != oldValue)
            {
                sheet.HeaderLabel.Style = ((Style)newValue);
            }
        });

    public Style HeaderStyle
    {
        get => (Style)GetValue(HeaderStyleProperty);
        set => SetValue(HeaderStyleProperty, value);
    }


    #endregion

    public BottomSheet()
	{
		InitializeComponent();

        CloseBottomSheetButton.Source = ImageSource.FromResource(
            "XGENO.Maui.Controls.BottomSheet.icnmenuclose.png");
    }

	public async Task OpenBottomSheet()
    {
        this.InputTransparent = false;
        BackgroundFader.IsVisible = true;
        CloseBottomSheetButton.IsVisible = true;

        _ = BackgroundFader.FadeTo(1, shortDuration, Easing.SinInOut);
        _ = MainContent.TranslateTo(0, 0, regularDuration, Easing.SinInOut);
        await CloseBottomSheetButton.FadeTo(1, regularDuration, Easing.SinInOut);
    }

    public async Task CloseBottomSheet()
    {
        await CloseBottomSheetButton.FadeTo(0, shortDuration, Easing.SinInOut);
        _ = MainContent.TranslateTo(0, SheetHeight, shortDuration, Easing.SinInOut);
        await BackgroundFader.FadeTo(0, shortDuration, Easing.SinInOut);

        BackgroundFader.IsVisible = true;
        CloseBottomSheetButton.IsVisible = true;
        this.InputTransparent = true;
    }

    async void CloseBottomSheetButton_Tapped(System.Object sender, System.EventArgs e) =>
        await CloseBottomSheet();
}

//,typeof(XGENO.Maui.Controls.BottomSheet).GetTypeInfo().Assembly