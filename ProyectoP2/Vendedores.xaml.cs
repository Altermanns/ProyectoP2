namespace ProyectoP2;

public partial class Vendedores : ContentPage
{
    public Vendedores()
    {
        InitializeComponent();
    }

    private async void RegisterBTN_Clicked(object sender, EventArgs e)
    {
        // Capturar datos
        string id = idEntry.Text;
        string name = nameEntry.Text;
        string email = emailEntry.Text;
        DateTime? birthDate = birthDatePicker.Date;

        // Validación de datos
        if (!string.IsNullOrWhiteSpace(id) &&
            !string.IsNullOrWhiteSpace(name) &&
            !string.IsNullOrWhiteSpace(email) &&
            birthDate.HasValue)
        {
            // Registro exitoso
            await DisplayAlert("Registro exitoso", $"Usuario: {name}\nCorreo: {email}\nFecha de Nacimiento: {birthDate.Value.ToShortDateString()}\nID: {id}", "OK");
        }
        else
        {
            // Error en el registro
            await DisplayAlert("Registro fallido", "Por favor, complete todos los campos correctamente.", "OK");
        }
    }
}
