using Xamarin.Forms;

namespace kinnect
{
    public partial class kinnectPage : TabbedPage
    {
        public kinnectPage()
        {
            InitializeComponent();
            BarBackgroundColor = Color.FromRgb(44, 99, 133);


        }
        void FilterButton(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FilterPage());
        }



        void Mode_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ModePage());

        }

    }
}
