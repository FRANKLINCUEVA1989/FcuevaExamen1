namespace FcuevaExamen1.Vistas;

public partial class vRegistro : ContentPage
{
	public vRegistro(string usuario)
	{
		InitializeComponent();
        lblUsuario2.Text = "INFORMACION DE USUARIO: " + usuario;
    }

    private void btnFecha_Clicked(object sender, EventArgs e)
    {

        string fecha = dpFecha.Date.ToString("MM/dd/yyyy");
        lblFecha.Text = "FECHA:  " + fecha;
    }

    private void btnPicker_Clicked(object sender, EventArgs e)
    {

        string nombre = txtNombre.Text;
        string apellido = txtApllido.Text;
        string edad = txtEdad.Text;
        
                if (nombre == txtNombre.Text)
        {
            Navigation.PushAsync(new Resumen(nombre, apellido, edad));
        }

           }

    private void btnPais_Clicked(object sender, EventArgs e)
    {
        
        string nombre = txtNombre.Text;
        string apellido = txtApllido.Text;
        string edad = txtEdad.Text; 


        if (nombre == txtNombre.Text)
        {
            Navigation.PushAsync(new Resumen(nombre, apellido, edad));
        }


    }
}