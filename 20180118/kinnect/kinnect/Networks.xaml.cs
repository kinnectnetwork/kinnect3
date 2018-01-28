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




                var colors = new[]
                {
                new { value = Color.White, name = "White"},
                new { value = Color.Silver, name = "Silver" },
                new { value = Color.Gray, name = "Gray" },
                new { value = Color.Black, name = "Black" },
                new { value = Color.Red, name = "Red" },
                new { value = Color.Maroon, name = "Maroon" },
                new { value = Color.Yellow, name = "Yellow" },
                new { value = Color.Olive, name = "Olive" },
                new { value = Color.Lime, name = "Lime" },
                new { value = Color.Green, name = "Green" },
                new { value = Color.Aqua, name = "Aqua" },
                new { value = Color.Teal, name = "Teal" },
                new { value = Color.Blue, name = "Blue" },
                new { value = Color.Navy, name = "Navy" },
                new { value = Color.Pink, name = "Pink" },
                new { value = Color.Fuchsia, name = "Fuchsia" },
                new { value = Color.Purple, name = "Purple" },

            };
            var user = new[] { 
                new {Name = "Ahnaf" },
                new {Name = "john" },
                new {Name = "jonny" },
                new {Name = "bitch" },
                new {Name = "kutta"},
            
            };

                StackLayout stackLayout = new StackLayout

                {
                    Orientation = StackOrientation.Horizontal,

                    BackgroundColor = Color.White,






                };



                foreach (var Name in user)
                {
                    stackLayout.Children.Add
                        (
                                   new Label
                        {

                            
                            
                            FontSize = 50,
                            VerticalTextAlignment = TextAlignment.Center,

                        }
                            );

                }

                
                Content = new ScrollView
                {
                    Orientation = ScrollOrientation.Horizontal,
                    Content = stackLayout
                };
            }
        }
    }
    

