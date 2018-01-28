using System;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;


using Xamarin.Forms;

namespace kinnect
{
    public partial class Networks : ContentPage
    {
        public Networks()
        {
            InitializeComponent();

            var names = new List<string>
            {
                "Mohammed", "Ali", "Marwen", "Ahmed"

            };

            MainCarouselView.ItemsSource = names;
        }
    }
}
