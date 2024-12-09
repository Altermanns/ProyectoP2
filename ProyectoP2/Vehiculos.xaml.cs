using ProyectoP2.Datos;

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
        string tipoCombustible = combustibleEntry.Text;
        string ubicacion = ubicacionEntry.Text;

        if (!string.IsNullOrWhiteSpace(marca) &&
            !string.IsNullOrWhiteSpace(modelo) &&
            !string.IsNullOrWhiteSpace(anio) &&
            !string.IsNullOrWhiteSpace(precio) &&
            !string.IsNullOrWhiteSpace(kilometraje) &&
            !string.IsNullOrWhiteSpace(tipoCombustible) &&
            !string.IsNullOrWhiteSpace(ubicacion))
        {
            var auto = new Auto
            {
                Marca = marca,
                Modelo = modelo,
                Anio = anio,
                Precio = precio,
                Kilometraje = kilometraje,
                Combustible = tipoCombustible,
                Ubicacion = ubicacion
            };

            AutoData.Autos.Add(auto);

            await DisplayAlert("Auto agregado", "Se ha registrado el automóvil correctamente.", "OK");

            marcaEntry.Text = string.Empty;
            modeloEntry.Text = string.Empty;
            anioEntry.Text = string.Empty;
            precioEntry.Text = string.Empty;
            kilometrajeEntry.Text = string.Empty;
            combustibleEntry.Text = string.Empty;
            ubicacionEntry.Text = string.Empty;
        }
        else
        {
            await DisplayAlert("Error", "Por favor, complete todos los campos.", "OK");
        }
    }
}