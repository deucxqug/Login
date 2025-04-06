using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Inicio : ContentPage
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUser.Text;
            string password = txtPw.Text;
            if (usuario == "admin" && password == "1234")
            {
                Navigation.PushAsync(new Dashboard());
            }
            else
            {
                lblError.Text = "Usuario o contraseña incorrectos";
            }
        }
    }
}