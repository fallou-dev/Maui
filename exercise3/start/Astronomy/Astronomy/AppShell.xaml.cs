using Astronomy.Pages;

namespace Astronomy;

public partial class AppShell : Shell
{
    public AppShell()
    {
        Routing.RegisterRoute("astronomicalbodydetails", typeof(AstronomicalBodyPage));
    }
    [QueryProperty(nameof(AstroName), "astroName")]

    public partial class AstronomicalBodyPage
    {
        InitializeComponent();

        btnComet.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails");
        btnEarth.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails");
        btnMoon.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails");
        btnSun.Clicked += async (s, e) => await Shell.Current.GoToAsync("astronomicalbodydetails");
    
    
    }
    string astroName;
    public string AstroName
    {
        get => astroName;
        set
        {
            astroName = value;

            // this is a custom function to update the UI immediately
            UpdateAstroBodyUI(astroName);
        }
    }


}
