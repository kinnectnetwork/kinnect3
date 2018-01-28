using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace kinnect
{
    public partial class Account : ContentPage
    {

        public class Dados
        {
            public string img { get; set; }
            public string texto { get; set; }
        }


        List<Dados> lista;



        public Account()
        {
            InitializeComponent();

            lista = new List<Dados>();

            lista.Add(new Dados
            {
                img="ic_chat.png",
                texto="Chats"

            });

            lista.Add(new Dados
            {
                img = "ic_people.png",
                texto = "People"

            });


            lista.Add(new Dados
            {
                img = "ic_search.png",
                texto = "Search"

            });


            car.ItemsSource = lista;


        }
    }
}
