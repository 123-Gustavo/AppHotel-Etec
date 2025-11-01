namespace MauiAppHotel.Views;

public partial class SobreHospedagem : ContentPage
{
	public SobreHospedagem()
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
                if (botao.Text == "Voltar")
                {
                    App.Current.MainPage = new Views.HomeHospedagem();
                }
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Fechar");
        }
    }
}