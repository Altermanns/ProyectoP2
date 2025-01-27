namespace ProyectoP2;

public partial class ListaAutos : ContentPage
{
    public ListaAutos()
    {
        InitializeComponent();
        AutosListView.ItemsSource = AutoData.Autos;
    }


}
