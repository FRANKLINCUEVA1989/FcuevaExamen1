namespace FcuevaExamen1.Vistas;

public partial class Acerca : ContentPage
{
	public Acerca(string usuario)
	{
		InitializeComponent();
		lblUsuario1.Text = "INFORMACION DE USUARIO: " + usuario;
	}
}