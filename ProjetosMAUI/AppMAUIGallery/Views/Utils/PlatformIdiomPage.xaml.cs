namespace AppMAUIGallery.Views.Utils;

public partial class PlatformIdiomPage : ContentPage
{
	public PlatformIdiomPage()
	{
		InitializeComponent();

		#if WINDOWS
			DisplayAlert("Condi��es de Compila��o", "Esta mensagem de executada s� no Windows usando Condi��es de Compila��o", "OK");
		#endif


        if (Device.RuntimePlatform == Device.WinUI)
		{
			DisplayAlert("Windows", "Esta mensagem � exclusiva do Windows", "OK");
		}

		if(Device.Idiom == TargetIdiom.Desktop)
		{
			DisplayAlert("Desktop", "Esta mensagem � exclusiva do Desktop/PC", "OK");
		}
	}
}