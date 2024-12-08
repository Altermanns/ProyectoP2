using System.Diagnostics.CodeAnalysis;
namespace ProyectoP2;

public partial class Vendedores : ContentPage
{
    public Vendedores()
    {
        InitializeComponent();
    }

    private async void LoggingBTN_Clicked(object sender, EventArgs e)
    {
        string username = usernameEntry.Text;
        string password = passwordEntry.Text;

        // Validación de datos
        if (!string.IsNullOrWhiteSpace(username) && !string.IsNullOrWhiteSpace(password))
        {
            await DisplayAlert("Registro exitoso", "Se ha registrado correctamente.", "OK");
        }
        else
        {
            await DisplayAlert("Registro fallido", "Por favor, complete todos los campos.", "OK");
        }
    }
}
