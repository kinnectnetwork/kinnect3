using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace kinnect
{
    public partial class FilterPage : ContentPage
    {
        public FilterPage()
        {
            InitializeComponent();
        }
        void DistanceSlider_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            txtResult.Text = "Distance            Within :" + DistanceSlider.Value + " km";
        }
    }
}
