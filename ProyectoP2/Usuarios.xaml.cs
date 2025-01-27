namespace ProyectoP2;

public partial class Usuarios : ContentPage
{
	public Usuarios()
	{
		InitializeComponent();
	}

    private async void RegistrarCompradorBTN_Clicked(object sender, EventArgs e)
    {
        // Capturar los datos de los campos
        string nombre = nombreEntry.Text;
        string correo = correoEntry.Text;
        DateTime? fechaNacimiento = fechaNacimientoPicker.Date;

        // Validación de los datos
        if (!string.IsNullOrWhiteSpace(nombre) &&
            !string.IsNullOrWhiteSpace(correo) &&
            fechaNacimiento.HasValue)
        {
            // Aquí puedes agregar el código para guardar los datos en la base de datos

            // Mostrar mensaje de éxito
            await DisplayAlert("Registro exitoso", $"Comprador: {nombre}\nCorreo: {correo}\nFecha de Nacimiento: {fechaNacimiento.Value.ToShortDateString()}", "OK");
        }
        else
        {
            // Mostrar mensaje de error si faltan campos
            await DisplayAlert("Registro fallido", "Por favor, complete todos los campos correctamente.", "OK");
        }
    }
}