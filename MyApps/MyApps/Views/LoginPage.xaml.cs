using Xamarin.Forms;

namespace MyApps.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

            LogoSource.Source = ImageSource.FromResource("MyApps.Icons.logo.png");
        }
    }
}
