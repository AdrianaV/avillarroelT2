namespace avillarroelT2.Views;

public partial class login : ContentPage
{
	public login()
	{
		InitializeComponent();
	}

    string[] listaUsuarios = { "Carlos", "Ana", "Jose" };
    string[] listaContase�as = { "carlos123", "ana123", "jose123" };

    string user;
    string password;

    public login(string usuario, string contrasena)
    {
        InitializeComponent();
        this.user = usuario;
        this.password = contrasena;
    }

    private void btn_inicio_Clicked(object sender, EventArgs e)
    {
        bool registrado = false;

        // Verificar si el usuario y la contrase�a coinciden con los almacenados
        for (int i = 0; i < listaUsuarios.Length; i++)
        {
            if (listaUsuarios[i] == txt_usuario.Text && listaContase�as[i] == txt_contrasena.Text)
            {
                registrado = true;
                break;
            }
        }
        if (registrado)
        {
            Navigation.PushAsync(new vprincipal(txt_usuario.Text));
        }
        else
        {
            DisplayAlert("ERROR", "USUARIO O CONTRASE�A INCORRECTO", "OK");
        }
    }

    private void btn_crear_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new registrar());
    }
}