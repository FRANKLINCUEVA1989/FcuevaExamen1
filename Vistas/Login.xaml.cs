namespace FcuevaExamen1.Vistas;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasena = txtContrasena.Text;

        if (usuario == "frank" && contrasena == "123")
        {
            Navigation.PushAsync(new vRegistro(usuario));
        }
        else
        {
            DisplayAlert("Alerta", "USUARIO Y/O CONTRASENA INCORRECTOS ", "Cerrar");
        }




    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {

        string usuario = txtUsuario.Text;    
        string contrasena = txtContrasena.Text;

        if (usuario == "frank" && contrasena == "123")
        {
            Navigation.PushAsync(new Acerca(usuario));
        }
        else
        {
            DisplayAlert("Alerta", " NO EXISTE INFORMACION REGISTRADA DEL ESTUDIANTE ", "Cerrar");
        }





    }
}