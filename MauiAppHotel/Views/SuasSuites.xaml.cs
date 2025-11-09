namespace MauiAppHotel.Views;

public partial class SuasSuites : ContentPage
{
	public SuasSuites()
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
                    App.Current.MainPage = new HomeHospedagem();
                }
            }
        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "Fechar");
        }
    }
}