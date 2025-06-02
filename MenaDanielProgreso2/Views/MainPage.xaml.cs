using MenaDanielProgreso2.Views;

namespace MenaDanielProgreso2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }
    }

}
