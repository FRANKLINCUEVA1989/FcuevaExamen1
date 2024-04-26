namespace FcuevaExamen1.Vistas;

public partial class Resumen : ContentPage
{
   
	public Resumen(string nombre, string apellido, string edad)
	{
		InitializeComponent();

        txtNombre.Text = nombre;
        txtApellido.Text = apellido;
        txtEdad.Text = edad; 
        

        //DisplayAlert("Alerta", "Biemvenido " + txtApellido , "\n tienes " + txtApellido, " cerrar");


        DisplayAlert("Alerta", " " + txtNombre ," "+ txtApellido, " "+ txtEdad +"Cerrar");


        //DisplayAlert("Alerta", "Biemvenido " + txtApellido, "\n tienes " + " cerrar");

    }



    private void btnResumen_Clicked(object sender, EventArgs e)
    {
    }
}