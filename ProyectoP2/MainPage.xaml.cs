namespace ProyectoP2;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void IrAgregarAuto(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Vehiculos());
    }

    private async void IrListaAutos(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ListaAutos());
    }
}
