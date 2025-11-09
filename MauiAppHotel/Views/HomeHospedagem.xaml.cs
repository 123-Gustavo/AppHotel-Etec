namespace MauiAppHotel.Views;

public partial class HomeHospedagem : ContentPage
{
	public HomeHospedagem()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            Button botao = (Button)sender;
            if (botao != null)
            {
                switch (botao.Text)
                {
                    case "Sobre":
                        App.Current.MainPage = new Views.SobreHospedagem();
                        break;
                    case "Diária":
                        App.Current.MainPage = new Views.ContratacaoHospedagem();
                        break;
                    case "Suas Suites":
                        App.Current.MainPage = new Views.SuasSuites();
                        break;
                }
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Fechar");
        }
    }
}