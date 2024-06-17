namespace avillarroelT2.Views;

public partial class registrar : ContentPage
{
	public registrar()
	{
		InitializeComponent();
	}

    private void btn_guardar_Clicked(object sender, EventArgs e)
    {
        string usuario = txt_usuario.Text;
        string contrasena = txt_contrasena.Text;
        DisplayAlert("ALERTA", "USUARIO GUARDADO", "OK");
        Navigation.PushAsync(new login(usuario, contrasena));
    }

    private void btn_cancelar_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new login());
    }
}