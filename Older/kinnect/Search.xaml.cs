﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace kinnect
{
    public partial class Search : CarouselPage
    {
        public Search()
        {
            InitializeComponent();
        }
        void FilterButton(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FilterPage());
        }
         
        

    }
}
