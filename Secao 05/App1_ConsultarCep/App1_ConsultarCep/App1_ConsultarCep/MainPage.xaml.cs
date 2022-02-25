using App1_ConsultarCep.Services;
using App1_ConsultarCep.Services.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1_ConsultarCep
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            BUTTON.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            //TODO - Lógica do Programa


            //TODO - Validações

            string cep = CEP.Text.Trim();
            Endereco endereco = ViaCEPService.BuscarEnderecoViaCEP(cep);

            RESULTADO.Text = string.Format("Endereco: {0}, {1} {2}", endereco.localidade, endereco.uf, endereco.logradouro);
        }
    }
}
