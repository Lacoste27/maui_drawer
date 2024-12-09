namespace ExempleApp;

public partial class MainPage : ContentPage
{
    int count = 0;
    
    private bool _isDrawerOpen = false;

    public MainPage()
    {
        InitializeComponent();
    }
    
    private async void OpenDrawer(object sender, EventArgs e)
    {
        Overlay.IsVisible = true;
        await Overlay.FadeTo(0.5, 250, Easing.CubicInOut);

        MenuContent.IsVisible = true;
        MenuButton.IsVisible = false;

        DrawerColumn.Width = new GridLength(250); // Drawer ouvert
        MainContentColumn.Width = new GridLength(1, GridUnitType.Star); // Réduction du contenu principal

        _isDrawerOpen = true;
    }

    private async void CloseDrawer(object sender, EventArgs e)
    {
        await Overlay.FadeTo(0, 250, Easing.CubicInOut);
        Overlay.IsVisible = false;

        MenuContent.IsVisible = false;
        MenuButton.IsVisible = true;

        DrawerColumn.Width = new GridLength(60); // Drawer fermé
        MainContentColumn.Width = new GridLength(1, GridUnitType.Star); // Contenu principal reprend tout l'espace

        _isDrawerOpen = false;
    }

    private async void OnPanUpdated(object sender, PanUpdatedEventArgs e)
    {
        // Ajoute un effet de glissement si nécessaire (optionnel)
    }
}