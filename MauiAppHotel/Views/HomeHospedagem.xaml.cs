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
                if(botao.Text == "Sobre")
                {
                    App.Current.MainPage = new Views.SobreHospedagem();
                }else if(botao.Text == "Diária")
                {
                    App.Current.MainPage = new Views.ContratacaoHospedagem();
                }
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Fechar");
        }
    }
}