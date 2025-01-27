using ProyectoP2.Models;
using System;
using System.Collections.Generic;

namespace ProyectoP2
{
    public partial class Transacciones : ContentPage
    {
        public List<Transaccion> Transaccion { get; set; }

        public Transacciones()
        {
            InitializeComponent();

            Transaccion = new List<Transaccion>
            {
                new Transaccion
                {
                    Vendedor = new Vendedor { Nombre = "Juan P�rez" },
                    Comprador = new Comprador { Nombre = "Ana G�mez" },
                    Vehiculo = new Vehiculo { Marca = "Toyota", Modelo = "Corolla" },
                    FechaTransaccion = DateTime.Now,
                    PrecioFinal = 15000
                }
            };

            BindingContext = this;
        }

        private async void RegistrarTransaccion_Clicked(object sender, EventArgs e)
        {
            try
            {
                int idVendedor = int.Parse(VendedorEntry.Text);
                int idComprador = int.Parse(CompradorEntry.Text);
                int idVehiculo = int.Parse(VehiculoEntry.Text);
                DateTime fechaTransaccion = FechaPicker.Date;
                double precioFinal = double.Parse(PrecioEntry.Text);

                var nuevaTransaccion = new Transaccion
                {
                    IdVendedor = idVendedor,
                    Vendedor = new Vendedor { Nombre = $"Vendedor {idVendedor}" }, 
                    IdComprador = idComprador,
                    Comprador = new Comprador { Nombre = $"Comprador {idComprador}" },
                    IdVehiculo = idVehiculo,
                    Vehiculo = new Vehiculo { Marca = $"Veh�culo {idVehiculo}", Modelo = "Modelo X" }, 
                    FechaTransaccion = fechaTransaccion,
                    PrecioFinal = precioFinal
                };

                Transaccion.Add(nuevaTransaccion);

                BindingContext = null;
                BindingContext = this;

                await DisplayAlert("�xito", "La transacci�n fue registrada correctamente.", "OK");
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", $"Ocurri� un error: {ex.Message}", "OK");
            }
        }
    }
}
