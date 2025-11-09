namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		try
		{

            App.Current.MainPage = new NavigationPage(new HomeHospedagem());

        }
        catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "Fechar");
        }
    }
}