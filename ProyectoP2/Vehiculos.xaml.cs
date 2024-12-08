namespace ProyectoP2;

public partial class Vehiculos : ContentPage
{
    public Vehiculos()
    {
        InitializeComponent();
    }
    private async void AgregarAutoBTN_Clicked(object sender, EventArgs e)
    {
        string marca = marcaEntry.Text;
        string modelo = modeloEntry.Text;
        string anio = anioEntry.Text;
        string precio = precioEntry.Text;
        string kilometraje = kilometrajeEntry.Text;
        string tipoCombustible = combustiblePicker.SelectedItem as string;
        string ubicacion = ubicacionEntry.Text;

        if (!string.IsNullOrWhiteSpace(marca) &&
            !string.IsNullOrWhiteSpace(modelo) &&
            !string.IsNullOrWhiteSpace(anio) &&
            !string.IsNullOrWhiteSpace(precio) &&
            !string.IsNullOrWhiteSpace(kilometraje) &&
            !string.IsNullOrWhiteSpace(tipoCombustible) &&
            !string.IsNullOrWhiteSpace(ubicacion))
        {
            await DisplayAlert("Auto agregado",
                $"Marca: {marca}\nModelo: {modelo}\nAño: {anio}\nPrecio: {precio}\nKilometraje: {kilometraje}\nCombustible: {tipoCombustible}\nUbicación: {ubicacion}",
                "OK");
        }
        else
        {
            await DisplayAlert("Registro fallido", "Por favor, complete todos los campos correctamente.", "OK");
        }
    }
}