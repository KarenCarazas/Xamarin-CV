using formscv.NewFolder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace formscv
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            DatePicker.Date = DateTime.Today;
        }
        private async void EnviarButton_Clicked(object sender, EventArgs e)
        {
            // Obtener los valores de los controles en MainPage
            string Name = NameEntry.Text;

            string Born = DatePicker.Date.ToString("dd/MM/yyyy");
            string Phone = PhoneEntry.Text;
            string Correo = CorreoEntry.Text;
            string Nation = NationPicker.SelectedItem?.ToString();
            string Ocupation = OcupationEntry.Text;
            string Perfil = PerfilEntry.Text;

            string Ingles = ObtenerNivelIngles();
            string Programacion = LengPicker.SelectedItem?.ToString();
            //string aptitudes = AptitudesEntry.Text;
            bool Agilidad = AgilidadCheckBox.IsChecked;
            bool Creatividad = CreatividadCheckBox.IsChecked;
            bool Ingenio = IngenioCheckBox.IsChecked;



            // Pasar los datos a CVPage y navegar a esa página
            FormPage cvPage = new FormPage(Name, Born, Phone, Correo, Nation, Ocupation, Perfil, Ingles, Programacion, Agilidad, Creatividad, Ingenio);
            await Navigation.PushAsync(cvPage);
        }

        private string ObtenerNivelIngles()
        {
            if (BasicRadioButton.IsChecked)
                return "Básico";
            else if (InterRadioButton.IsChecked)
                return "Intermedio";
            else if (FluidRadioButton.IsChecked)
                return "Fluido";
            else
                return string.Empty;
        }
    }
}