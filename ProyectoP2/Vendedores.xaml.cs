namespace ProyectoP2;

public partial class Vendedores : ContentPage
{
    public Vendedores()
    {
        InitializeComponent();
    }

    private async void LoggingBTN_Clicked(object sender, EventArgs e)
    {
        string name = nameEntry.Text;
        string email = emailEntry.Text;
        DateTime birthDate = birthDatePicker.Date;

        if (!string.IsNullOrWhiteSpace(name) &&
            !string.IsNullOrWhiteSpace(email) &&
            birthDate != null)
        {
            await DisplayAlert("Registro exitoso",
                $"Nombre: {name}\nCorreo: {email}\nFecha de Nacimiento: {birthDate.ToShortDateString()}",
                "OK");
        }
        else
        {
            await DisplayAlert("Registro fallido", "Por favor, complete todos los campos.", "OK");
        }
    }
}
