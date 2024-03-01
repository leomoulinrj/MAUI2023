using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;

namespace AppMAUIGallery.Views.CommunityMaui;

public partial class AlertsPage : ContentPage
{
	public AlertsPage()
	{
		InitializeComponent();
	}

    private void OnButtonClicked_ShowSnackbar(object sender, EventArgs e)
    {
		//Configura��o Visual
		var options = new SnackbarOptions
		{
			BackgroundColor = Colors.White,
			TextColor = Colors.Green,
		};
		//Cria��o do Objeto
		var snackbar = Snackbar.Make("Ocorreu um erro inesperado!", null, "OK", TimeSpan.FromSeconds(5), options);

		//Apresenta��o da Snack
		snackbar.Show();
    }

    private void OnButtonClicked_ShowToast(object sender, EventArgs e)
    {
		var toast = Toast.Make("Ocorreu um erro inesperado!", ToastDuration.Long, 18);

		toast.Show();
    }
}