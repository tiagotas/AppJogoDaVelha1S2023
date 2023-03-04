using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button botao_clicado = (Button)sender;

            botao_clicado.IsEnabled = false;

            if(vez == "X")
            {
                botao_clicado.Text = "X";
                vez = "O";
            } else
            {
                botao_clicado.Text = "O";
                vez = "X";
            }
            
            /* Verificando se o X ganhou na primeira linha */
            if(btn10.Text == "X" && 
               btn11.Text == "X" &&
               btn12.Text == "X")
            {
                DisplayAlert("Ganhou!", "O X ganhou!", "OK");
                zerar();
            }
        }

        public void zerar()
        {
            btn10.IsEnabled = true;
            btn10.Text = "";
            btn11.IsEnabled = true;
            btn11.Text = "";
            btn12.IsEnabled = true;
            btn12.Text = "";

            btn20.IsEnabled = true;
            btn20.Text = "";
            btn21.IsEnabled = true;
            btn21.Text = "";
            btn22.IsEnabled = true;
            btn22.Text = "";

            btn30.IsEnabled = true;
            btn30.Text = "";
            btn31.IsEnabled = true;
            btn31.Text = "";
            btn32.IsEnabled = true;
            btn32.Text = "";
        }
    }
}
